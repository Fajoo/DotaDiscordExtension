using System;
using System.Threading;
using System.Threading.Tasks;
using Dota2GSI;
using Dota2GSI.Nodes;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Core.Models;
using DotaDiscordExtension.Core.Resources;

namespace DotaDiscordExtension.Core
{
    public class Dota2Provider : IDota2Provider
    {
        public event StateGame StateGame;

        private DotaModel _model;

        private GameStateListener _listener;

        public Dota2Provider()
        {
            _listener = new GameStateListener(4000);
        }

        public bool Start()
        {
            if (_listener.Running) return true;

            _listener.NewGameState += ListenerOnNewGameState;

            _model = new DotaModel();

            return _listener.Start();
        }

        private void ListenerOnNewGameState(GameState gameState)
        {
            try
            {
                var state = gameState.Map.GameState;

                if (state == DOTA_GameState.Undefined)
                {
                    StateGame?.Invoke(this, null);
                    return;
                }

                _model.KDA = (gameState.Player.Kills.ToString(), gameState.Player.Deaths.ToString(), gameState.Player.Assists.ToString());
                _model.Hero = Dota2Names.GetHeroName(gameState.Hero.Name);
                _model.Team = gameState.Player.Team.ToString();
                _model.Lvl = gameState.Hero.Level.ToString();
                _model.GameState = "In game";

                if (gameState.Hero.Level == -1)
                    _model.GameState = "Picking a hero";

                StateGame?.Invoke(this, _model);
            }
            catch
            {
                // ignored
            }
        }

        public void Stop() => Dispose();

        public void Dispose()
        {
            _model = new DotaModel();
            _listener.Stop();
        }
    }
}