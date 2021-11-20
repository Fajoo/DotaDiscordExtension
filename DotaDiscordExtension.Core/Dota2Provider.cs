using System;
using Dota2GSI;
using Dota2GSI.Nodes;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Core.Models;
using DotaDiscordExtension.Core.Models.DotaData;

namespace DotaDiscordExtension.Core
{
    public class Dota2Provider : IDota2Provider
    {
        public event StateGame StateGame;

        private DotaModel _model;
        //private GameStateListener _listener;
        private readonly Dota2Listener _dota2Listener;

        public Dota2Provider()
        {
            _model = new DotaModel();
            //_listener = new GameStateListener(4000);
            //_listener.NewGameState += ListenerOnNewGameState;

            _dota2Listener = new Dota2Listener("http://localhost:4000/");
            _dota2Listener.GetDotaInfo += Dota2ListenerOnGetDotaInfo;
        }

        private void Dota2ListenerOnGetDotaInfo(DotaInfo dotaInfo)
        {
            try
            {
                if (dotaInfo.Map?.GameState == "DOTA_GAMERULES_STATE_GAME_IN_UNDEFINED" 
                    || dotaInfo.Player.Activity != "playing")
                {
                    StateGame?.Invoke(this, null);
                    return;
                }

                _model.KDA = (dotaInfo.Player.Kills, dotaInfo.Player.Deaths, dotaInfo.Player.Assists);

                //_model.KDA = (dotaInfo.Player.kills.ToString(), dotaInfo.Player.deaths.ToString(),
                //    dotaInfo.Player.assists.ToString());

                _model.Hero = string.Equals(dotaInfo.Hero.Name, "npc_dota_hero_keeper_of_the_light")
                    ? "npc_dota_hero_kotl"
                    : dotaInfo.Hero.Name;

                _model.Team = dotaInfo.Player.team_name;
                _model.Lvl = dotaInfo.Hero.Level;
                _model.GameState = "In game";

                if (dotaInfo.Hero.Level == -1)
                    _model.GameState = "Picking a hero";

                StateGame?.Invoke(this, _model);
            }
            catch
            {
                // ignored
            }
        }

        public bool Start()
        {
            _ = _dota2Listener.Start();
            return true;
        }

        //private void ListenerOnNewGameState(GameState gameState)
        //{
        //    try
        //    {
        //        var state = gameState.Map.GameState;

        //        Console.WriteLine(DateTime.Now);

        //        if (state == DOTA_GameState.Undefined || gameState.Player.Activity != PlayerActivity.Playing)
        //        {
        //            StateGame?.Invoke(this, null);
        //            return;
        //        }

        //        _model.KDA = (gameState.Player.Kills.ToString(), gameState.Player.Deaths.ToString(), gameState.Player.Assists.ToString());
        //        _model.Hero = string.Equals(gameState.Hero.Name, "npc_dota_hero_keeper_of_the_light") ? "npc_dota_hero_kotl" : gameState.Hero.Name;
        //        _model.Team = gameState.Player.Team.ToString();
        //        _model.Lvl = gameState.Hero.Level.ToString();
        //        _model.GameState = "In game";

        //        if (gameState.Hero.Level == -1)
        //            _model.GameState = "Picking a hero";

        //        StateGame?.Invoke(this, _model);
        //    }
        //    catch
        //    {
        //        // ignored
        //    }
        //}

        public void Stop() => Dispose();

        public void Dispose()
        {
            _model = new DotaModel();
            //_listener.Stop();

            _dota2Listener.Stop();
        }
    }
}