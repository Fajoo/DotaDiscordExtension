namespace DotaDiscordExtension.ConsoleTests
{
    public class DAL
    {


        public class Rootobject
        {
            public Provider provider { get; set; }
            public Map map { get; set; }
            public Player player { get; set; }
            public Hero hero { get; set; }
            public Abilities abilities { get; set; }
            public Items items { get; set; }
        }

        public class Provider
        {
            public string name { get; set; }
            public int appid { get; set; }
            public int version { get; set; }
            public int timestamp { get; set; }
        }

        public class Map
        {
            public string name { get; set; }
            public string matchid { get; set; }
            public int game_time { get; set; }
            public int clock_time { get; set; }
            public bool daytime { get; set; }
            public bool nightstalker_night { get; set; }
            public string game_state { get; set; }
            public bool paused { get; set; }
            public string win_team { get; set; }
            public string customgamename { get; set; }
            public int radiant_ward_purchase_cooldown { get; set; }
            public int dire_ward_purchase_cooldown { get; set; }
            public string roshan_state { get; set; }
            public int roshan_state_end_seconds { get; set; }
        }

        public class Player
        {
            public Team2 team2 { get; set; }
            public Team3 team3 { get; set; }
        }

        public class Team2
        {
            public Player0 player0 { get; set; }
            public Player1 player1 { get; set; }
            public Player2 player2 { get; set; }
            public Player3 player3 { get; set; }
            public Player4 player4 { get; set; }
        }

        public class Player0
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List
        {
            public int victimid_6 { get; set; }
            public int victimid_9 { get; set; }
        }

        public class Player1
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List1 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List1
        {
            public int victimid_5 { get; set; }
            public int victimid_6 { get; set; }
            public int victimid_7 { get; set; }
            public int victimid_9 { get; set; }
        }

        public class Player2
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List2 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List2
        {
            public int victimid_5 { get; set; }
            public int victimid_7 { get; set; }
            public int victimid_8 { get; set; }
        }

        public class Player3
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List3 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List3
        {
            public int victimid_7 { get; set; }
            public int victimid_9 { get; set; }
        }

        public class Player4
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List4 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List4
        {
            public int victimid_5 { get; set; }
            public int victimid_8 { get; set; }
            public int victimid_9 { get; set; }
        }

        public class Team3
        {
            public Player5 player5 { get; set; }
            public Player6 player6 { get; set; }
            public Player7 player7 { get; set; }
            public Player8 player8 { get; set; }
            public Player9 player9 { get; set; }
        }

        public class Player5
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List5 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List5
        {
            public int victimid_2 { get; set; }
            public int victimid_3 { get; set; }
            public int victimid_4 { get; set; }
        }

        public class Player6
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List6 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List6
        {
            public int victimid_0 { get; set; }
            public int victimid_4 { get; set; }
        }

        public class Player7
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List7 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List7
        {
            public int victimid_0 { get; set; }
            public int victimid_3 { get; set; }
            public int victimid_4 { get; set; }
        }

        public class Player8
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List8 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List8
        {
            public int victimid_0 { get; set; }
            public int victimid_1 { get; set; }
            public int victimid_2 { get; set; }
            public int victimid_4 { get; set; }
        }

        public class Player9
        {
            public string steamid { get; set; }
            public string name { get; set; }
            public string activity { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int kill_streak { get; set; }
            public int commands_issued { get; set; }
            public Kill_List9 kill_list { get; set; }
            public string team_name { get; set; }
            public int gold { get; set; }
            public int gold_reliable { get; set; }
            public int gold_unreliable { get; set; }
            public int gold_from_hero_kills { get; set; }
            public int gold_from_creep_kills { get; set; }
            public int gold_from_income { get; set; }
            public int gold_from_shared { get; set; }
            public int gpm { get; set; }
            public int xpm { get; set; }
            public int net_worth { get; set; }
            public int hero_damage { get; set; }
            public int wards_purchased { get; set; }
            public int wards_placed { get; set; }
            public int wards_destroyed { get; set; }
            public int runes_activated { get; set; }
            public int camps_stacked { get; set; }
            public int support_gold_spent { get; set; }
            public int consumable_gold_spent { get; set; }
            public int item_gold_spent { get; set; }
            public int gold_lost_to_death { get; set; }
            public int gold_spent_on_buybacks { get; set; }
        }

        public class Kill_List9
        {
            public int victimid_0 { get; set; }
            public int victimid_2 { get; set; }
            public int victimid_3 { get; set; }
            public int victimid_4 { get; set; }
        }

        public class Hero
        {
            public Team21 team2 { get; set; }
            public Team31 team3 { get; set; }
        }

        public class Team21
        {
            public Player01 player0 { get; set; }
            public Player11 player1 { get; set; }
            public Player21 player2 { get; set; }
            public Player31 player3 { get; set; }
            public Player41 player4 { get; set; }
        }

        public class Player01
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player11
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player21
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player31
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player41
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Team31
        {
            public Player51 player5 { get; set; }
            public Player61 player6 { get; set; }
            public Player71 player7 { get; set; }
            public Player81 player8 { get; set; }
            public Player91 player9 { get; set; }
        }

        public class Player51
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player61
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player71
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player81
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Player91
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public int xp { get; set; }
            public bool alive { get; set; }
            public int respawn_seconds { get; set; }
            public int buyback_cost { get; set; }
            public int buyback_cooldown { get; set; }
            public int health { get; set; }
            public int max_health { get; set; }
            public int health_percent { get; set; }
            public int mana { get; set; }
            public int max_mana { get; set; }
            public int mana_percent { get; set; }
            public bool silenced { get; set; }
            public bool stunned { get; set; }
            public bool disarmed { get; set; }
            public bool magicimmune { get; set; }
            public bool hexed { get; set; }
            public bool muted { get; set; }
            public bool _break { get; set; }
            public bool aghanims_scepter { get; set; }
            public bool aghanims_shard { get; set; }
            public bool smoked { get; set; }
            public bool has_debuff { get; set; }
            public bool selected_unit { get; set; }
            public bool talent_1 { get; set; }
            public bool talent_2 { get; set; }
            public bool talent_3 { get; set; }
            public bool talent_4 { get; set; }
            public bool talent_5 { get; set; }
            public bool talent_6 { get; set; }
            public bool talent_7 { get; set; }
            public bool talent_8 { get; set; }
        }

        public class Abilities
        {
            public Team22 team2 { get; set; }
            public Team32 team3 { get; set; }
        }

        public class Team22
        {
            public Player02 player0 { get; set; }
            public Player12 player1 { get; set; }
            public Player22 player2 { get; set; }
            public Player32 player3 { get; set; }
            public Player42 player4 { get; set; }
        }

        public class Player02
        {
            public Ability0 ability0 { get; set; }
            public Ability1 ability1 { get; set; }
            public Ability2 ability2 { get; set; }
            public Ability3 ability3 { get; set; }
            public Ability4 ability4 { get; set; }
        }

        public class Ability0
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability1
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability2
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability3
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability4
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player12
        {
            public Ability01 ability0 { get; set; }
            public Ability11 ability1 { get; set; }
            public Ability21 ability2 { get; set; }
            public Ability31 ability3 { get; set; }
            public Ability41 ability4 { get; set; }
            public Ability5 ability5 { get; set; }
        }

        public class Ability01
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability11
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability21
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability31
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability41
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability5
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player22
        {
            public Ability02 ability0 { get; set; }
            public Ability12 ability1 { get; set; }
            public Ability22 ability2 { get; set; }
            public Ability32 ability3 { get; set; }
            public Ability42 ability4 { get; set; }
            public Ability51 ability5 { get; set; }
        }

        public class Ability02
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability12
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability22
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability32
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability42
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability51
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player32
        {
            public Ability03 ability0 { get; set; }
            public Ability13 ability1 { get; set; }
            public Ability23 ability2 { get; set; }
            public Ability33 ability3 { get; set; }
            public Ability43 ability4 { get; set; }
            public Ability52 ability5 { get; set; }
            public Ability6 ability6 { get; set; }
        }

        public class Ability03
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability13
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability23
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability33
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
            public int charges { get; set; }
            public int max_charges { get; set; }
            public int charge_cooldown { get; set; }
        }

        public class Ability43
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability52
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability6
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player42
        {
            public Ability04 ability0 { get; set; }
            public Ability14 ability1 { get; set; }
            public Ability24 ability2 { get; set; }
            public Ability34 ability3 { get; set; }
            public Ability44 ability4 { get; set; }
            public Ability53 ability5 { get; set; }
            public Ability61 ability6 { get; set; }
            public Ability7 ability7 { get; set; }
        }

        public class Ability04
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability14
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability24
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability34
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability44
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability53
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability61
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability7
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Team32
        {
            public Player52 player5 { get; set; }
            public Player62 player6 { get; set; }
            public Player72 player7 { get; set; }
            public Player82 player8 { get; set; }
            public Player92 player9 { get; set; }
        }

        public class Player52
        {
            public Ability05 ability0 { get; set; }
            public Ability15 ability1 { get; set; }
            public Ability25 ability2 { get; set; }
            public Ability35 ability3 { get; set; }
            public Ability45 ability4 { get; set; }
            public Ability54 ability5 { get; set; }
        }

        public class Ability05
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability15
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability25
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability35
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability45
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability54
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player62
        {
            public Ability06 ability0 { get; set; }
            public Ability16 ability1 { get; set; }
            public Ability26 ability2 { get; set; }
            public Ability36 ability3 { get; set; }
            public Ability46 ability4 { get; set; }
            public Ability55 ability5 { get; set; }
        }

        public class Ability06
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability16
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability26
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability36
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability46
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability55
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player72
        {
            public Ability07 ability0 { get; set; }
            public Ability17 ability1 { get; set; }
            public Ability27 ability2 { get; set; }
            public Ability37 ability3 { get; set; }
            public Ability47 ability4 { get; set; }
            public Ability56 ability5 { get; set; }
        }

        public class Ability07
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability17
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability27
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability37
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability47
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability56
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player82
        {
            public Ability08 ability0 { get; set; }
            public Ability18 ability1 { get; set; }
            public Ability28 ability2 { get; set; }
            public Ability38 ability3 { get; set; }
            public Ability48 ability4 { get; set; }
            public Ability57 ability5 { get; set; }
        }

        public class Ability08
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability18
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability28
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability38
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability48
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability57
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Player92
        {
            public Ability09 ability0 { get; set; }
            public Ability19 ability1 { get; set; }
            public Ability29 ability2 { get; set; }
            public Ability39 ability3 { get; set; }
            public Ability49 ability4 { get; set; }
            public Ability58 ability5 { get; set; }
        }

        public class Ability09
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability19
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability29
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability39
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Ability49
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
            public int charges { get; set; }
            public int max_charges { get; set; }
            public int charge_cooldown { get; set; }
        }

        public class Ability58
        {
            public string name { get; set; }
            public int level { get; set; }
            public bool can_cast { get; set; }
            public bool passive { get; set; }
            public bool ability_active { get; set; }
            public int cooldown { get; set; }
            public bool ultimate { get; set; }
        }

        public class Items
        {
            public Team23 team2 { get; set; }
            public Team33 team3 { get; set; }
        }

        public class Team23
        {
            public Player03 player0 { get; set; }
            public Player13 player1 { get; set; }
            public Player23 player2 { get; set; }
            public Player33 player3 { get; set; }
            public Player43 player4 { get; set; }
        }

        public class Player03
        {
            public Slot0 slot0 { get; set; }
            public Slot1 slot1 { get; set; }
            public Slot2 slot2 { get; set; }
            public Slot3 slot3 { get; set; }
            public Slot4 slot4 { get; set; }
            public Slot5 slot5 { get; set; }
            public Slot6 slot6 { get; set; }
            public Slot7 slot7 { get; set; }
            public Slot8 slot8 { get; set; }
            public Stash0 stash0 { get; set; }
            public Stash1 stash1 { get; set; }
            public Stash2 stash2 { get; set; }
            public Stash3 stash3 { get; set; }
            public Stash4 stash4 { get; set; }
            public Stash5 stash5 { get; set; }
            public Teleport0 teleport0 { get; set; }
            public Neutral0 neutral0 { get; set; }
        }

        public class Slot0
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot1
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot2
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot3
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot4
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot5
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot6
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot7
        {
            public string name { get; set; }
        }

        public class Slot8
        {
            public string name { get; set; }
        }

        public class Stash0
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Stash1
        {
            public string name { get; set; }
        }

        public class Stash2
        {
            public string name { get; set; }
        }

        public class Stash3
        {
            public string name { get; set; }
        }

        public class Stash4
        {
            public string name { get; set; }
        }

        public class Stash5
        {
            public string name { get; set; }
        }

        public class Teleport0
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral0
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Player13
        {
            public Slot01 slot0 { get; set; }
            public Slot11 slot1 { get; set; }
            public Slot21 slot2 { get; set; }
            public Slot31 slot3 { get; set; }
            public Slot41 slot4 { get; set; }
            public Slot51 slot5 { get; set; }
            public Slot61 slot6 { get; set; }
            public Slot71 slot7 { get; set; }
            public Slot81 slot8 { get; set; }
            public Stash01 stash0 { get; set; }
            public Stash11 stash1 { get; set; }
            public Stash21 stash2 { get; set; }
            public Stash31 stash3 { get; set; }
            public Stash41 stash4 { get; set; }
            public Stash51 stash5 { get; set; }
            public Teleport01 teleport0 { get; set; }
            public Neutral01 neutral0 { get; set; }
        }

        public class Slot01
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot11
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot21
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot31
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot41
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot51
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot61
        {
            public string name { get; set; }
        }

        public class Slot71
        {
            public string name { get; set; }
        }

        public class Slot81
        {
            public string name { get; set; }
        }

        public class Stash01
        {
            public string name { get; set; }
        }

        public class Stash11
        {
            public string name { get; set; }
        }

        public class Stash21
        {
            public string name { get; set; }
        }

        public class Stash31
        {
            public string name { get; set; }
        }

        public class Stash41
        {
            public string name { get; set; }
        }

        public class Stash51
        {
            public string name { get; set; }
        }

        public class Teleport01
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral01
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Player23
        {
            public Slot02 slot0 { get; set; }
            public Slot12 slot1 { get; set; }
            public Slot22 slot2 { get; set; }
            public Slot32 slot3 { get; set; }
            public Slot42 slot4 { get; set; }
            public Slot52 slot5 { get; set; }
            public Slot62 slot6 { get; set; }
            public Slot72 slot7 { get; set; }
            public Slot82 slot8 { get; set; }
            public Stash02 stash0 { get; set; }
            public Stash12 stash1 { get; set; }
            public Stash22 stash2 { get; set; }
            public Stash32 stash3 { get; set; }
            public Stash42 stash4 { get; set; }
            public Stash52 stash5 { get; set; }
            public Teleport02 teleport0 { get; set; }
            public Neutral02 neutral0 { get; set; }
        }

        public class Slot02
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot12
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot22
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot32
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot42
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot52
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot62
        {
            public string name { get; set; }
        }

        public class Slot72
        {
            public string name { get; set; }
        }

        public class Slot82
        {
            public string name { get; set; }
        }

        public class Stash02
        {
            public string name { get; set; }
        }

        public class Stash12
        {
            public string name { get; set; }
        }

        public class Stash22
        {
            public string name { get; set; }
        }

        public class Stash32
        {
            public string name { get; set; }
        }

        public class Stash42
        {
            public string name { get; set; }
        }

        public class Stash52
        {
            public string name { get; set; }
        }

        public class Teleport02
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral02
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Player33
        {
            public Slot03 slot0 { get; set; }
            public Slot13 slot1 { get; set; }
            public Slot23 slot2 { get; set; }
            public Slot33 slot3 { get; set; }
            public Slot43 slot4 { get; set; }
            public Slot53 slot5 { get; set; }
            public Slot63 slot6 { get; set; }
            public Slot73 slot7 { get; set; }
            public Slot83 slot8 { get; set; }
            public Stash03 stash0 { get; set; }
            public Stash13 stash1 { get; set; }
            public Stash23 stash2 { get; set; }
            public Stash33 stash3 { get; set; }
            public Stash43 stash4 { get; set; }
            public Stash53 stash5 { get; set; }
            public Teleport03 teleport0 { get; set; }
            public Neutral03 neutral0 { get; set; }
        }

        public class Slot03
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot13
        {
            public string name { get; set; }
        }

        public class Slot23
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot33
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot43
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot53
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot63
        {
            public string name { get; set; }
        }

        public class Slot73
        {
            public string name { get; set; }
        }

        public class Slot83
        {
            public string name { get; set; }
        }

        public class Stash03
        {
            public string name { get; set; }
        }

        public class Stash13
        {
            public string name { get; set; }
        }

        public class Stash23
        {
            public string name { get; set; }
        }

        public class Stash33
        {
            public string name { get; set; }
        }

        public class Stash43
        {
            public string name { get; set; }
        }

        public class Stash53
        {
            public string name { get; set; }
        }

        public class Teleport03
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral03
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Player43
        {
            public Slot04 slot0 { get; set; }
            public Slot14 slot1 { get; set; }
            public Slot24 slot2 { get; set; }
            public Slot34 slot3 { get; set; }
            public Slot44 slot4 { get; set; }
            public Slot54 slot5 { get; set; }
            public Slot64 slot6 { get; set; }
            public Slot74 slot7 { get; set; }
            public Slot84 slot8 { get; set; }
            public Stash04 stash0 { get; set; }
            public Stash14 stash1 { get; set; }
            public Stash24 stash2 { get; set; }
            public Stash34 stash3 { get; set; }
            public Stash44 stash4 { get; set; }
            public Stash54 stash5 { get; set; }
            public Teleport04 teleport0 { get; set; }
            public Neutral04 neutral0 { get; set; }
        }

        public class Slot04
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot14
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot24
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public string contains_rune { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot34
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot44
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot54
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot64
        {
            public string name { get; set; }
        }

        public class Slot74
        {
            public string name { get; set; }
        }

        public class Slot84
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Stash04
        {
            public string name { get; set; }
        }

        public class Stash14
        {
            public string name { get; set; }
        }

        public class Stash24
        {
            public string name { get; set; }
        }

        public class Stash34
        {
            public string name { get; set; }
        }

        public class Stash44
        {
            public string name { get; set; }
        }

        public class Stash54
        {
            public string name { get; set; }
        }

        public class Teleport04
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral04
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Team33
        {
            public Player53 player5 { get; set; }
            public Player63 player6 { get; set; }
            public Player73 player7 { get; set; }
            public Player83 player8 { get; set; }
            public Player93 player9 { get; set; }
        }

        public class Player53
        {
            public Slot05 slot0 { get; set; }
            public Slot15 slot1 { get; set; }
            public Slot25 slot2 { get; set; }
            public Slot35 slot3 { get; set; }
            public Slot45 slot4 { get; set; }
            public Slot55 slot5 { get; set; }
            public Slot65 slot6 { get; set; }
            public Slot75 slot7 { get; set; }
            public Slot85 slot8 { get; set; }
            public Stash05 stash0 { get; set; }
            public Stash15 stash1 { get; set; }
            public Stash25 stash2 { get; set; }
            public Stash35 stash3 { get; set; }
            public Stash45 stash4 { get; set; }
            public Stash55 stash5 { get; set; }
            public Teleport05 teleport0 { get; set; }
            public Neutral05 neutral0 { get; set; }
        }

        public class Slot05
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot15
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot25
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot35
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot45
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot55
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot65
        {
            public string name { get; set; }
        }

        public class Slot75
        {
            public string name { get; set; }
        }

        public class Slot85
        {
            public string name { get; set; }
        }

        public class Stash05
        {
            public string name { get; set; }
        }

        public class Stash15
        {
            public string name { get; set; }
        }

        public class Stash25
        {
            public string name { get; set; }
        }

        public class Stash35
        {
            public string name { get; set; }
        }

        public class Stash45
        {
            public string name { get; set; }
        }

        public class Stash55
        {
            public string name { get; set; }
        }

        public class Teleport05
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral05
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Player63
        {
            public Slot06 slot0 { get; set; }
            public Slot16 slot1 { get; set; }
            public Slot26 slot2 { get; set; }
            public Slot36 slot3 { get; set; }
            public Slot46 slot4 { get; set; }
            public Slot56 slot5 { get; set; }
            public Slot66 slot6 { get; set; }
            public Slot76 slot7 { get; set; }
            public Slot86 slot8 { get; set; }
            public Stash06 stash0 { get; set; }
            public Stash16 stash1 { get; set; }
            public Stash26 stash2 { get; set; }
            public Stash36 stash3 { get; set; }
            public Stash46 stash4 { get; set; }
            public Stash56 stash5 { get; set; }
            public Teleport06 teleport0 { get; set; }
            public Neutral06 neutral0 { get; set; }
        }

        public class Slot06
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot16
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot26
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot36
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot46
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot56
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot66
        {
            public string name { get; set; }
        }

        public class Slot76
        {
            public string name { get; set; }
        }

        public class Slot86
        {
            public string name { get; set; }
        }

        public class Stash06
        {
            public string name { get; set; }
        }

        public class Stash16
        {
            public string name { get; set; }
        }

        public class Stash26
        {
            public string name { get; set; }
        }

        public class Stash36
        {
            public string name { get; set; }
        }

        public class Stash46
        {
            public string name { get; set; }
        }

        public class Stash56
        {
            public string name { get; set; }
        }

        public class Teleport06
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral06
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Player73
        {
            public Slot07 slot0 { get; set; }
            public Slot17 slot1 { get; set; }
            public Slot27 slot2 { get; set; }
            public Slot37 slot3 { get; set; }
            public Slot47 slot4 { get; set; }
            public Slot57 slot5 { get; set; }
            public Slot67 slot6 { get; set; }
            public Slot77 slot7 { get; set; }
            public Slot87 slot8 { get; set; }
            public Stash07 stash0 { get; set; }
            public Stash17 stash1 { get; set; }
            public Stash27 stash2 { get; set; }
            public Stash37 stash3 { get; set; }
            public Stash47 stash4 { get; set; }
            public Stash57 stash5 { get; set; }
            public Teleport07 teleport0 { get; set; }
            public Neutral07 neutral0 { get; set; }
        }

        public class Slot07
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot17
        {
            public string name { get; set; }
        }

        public class Slot27
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot37
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot47
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot57
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot67
        {
            public string name { get; set; }
        }

        public class Slot77
        {
            public string name { get; set; }
        }

        public class Slot87
        {
            public string name { get; set; }
        }

        public class Stash07
        {
            public string name { get; set; }
        }

        public class Stash17
        {
            public string name { get; set; }
        }

        public class Stash27
        {
            public string name { get; set; }
        }

        public class Stash37
        {
            public string name { get; set; }
        }

        public class Stash47
        {
            public string name { get; set; }
        }

        public class Stash57
        {
            public string name { get; set; }
        }

        public class Teleport07
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral07
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Player83
        {
            public Slot08 slot0 { get; set; }
            public Slot18 slot1 { get; set; }
            public Slot28 slot2 { get; set; }
            public Slot38 slot3 { get; set; }
            public Slot48 slot4 { get; set; }
            public Slot58 slot5 { get; set; }
            public Slot68 slot6 { get; set; }
            public Slot78 slot7 { get; set; }
            public Slot88 slot8 { get; set; }
            public Stash08 stash0 { get; set; }
            public Stash18 stash1 { get; set; }
            public Stash28 stash2 { get; set; }
            public Stash38 stash3 { get; set; }
            public Stash48 stash4 { get; set; }
            public Stash58 stash5 { get; set; }
            public Teleport08 teleport0 { get; set; }
            public Neutral08 neutral0 { get; set; }
        }

        public class Slot08
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot18
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot28
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot38
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot48
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot58
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot68
        {
            public string name { get; set; }
        }

        public class Slot78
        {
            public string name { get; set; }
        }

        public class Slot88
        {
            public string name { get; set; }
        }

        public class Stash08
        {
            public string name { get; set; }
        }

        public class Stash18
        {
            public string name { get; set; }
        }

        public class Stash28
        {
            public string name { get; set; }
        }

        public class Stash38
        {
            public string name { get; set; }
        }

        public class Stash48
        {
            public string name { get; set; }
        }

        public class Stash58
        {
            public string name { get; set; }
        }

        public class Teleport08
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral08
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Player93
        {
            public Slot09 slot0 { get; set; }
            public Slot19 slot1 { get; set; }
            public Slot29 slot2 { get; set; }
            public Slot39 slot3 { get; set; }
            public Slot49 slot4 { get; set; }
            public Slot59 slot5 { get; set; }
            public Slot69 slot6 { get; set; }
            public Slot79 slot7 { get; set; }
            public Slot89 slot8 { get; set; }
            public Stash09 stash0 { get; set; }
            public Stash19 stash1 { get; set; }
            public Stash29 stash2 { get; set; }
            public Stash39 stash3 { get; set; }
            public Stash49 stash4 { get; set; }
            public Stash59 stash5 { get; set; }
            public Teleport09 teleport0 { get; set; }
            public Neutral09 neutral0 { get; set; }
        }

        public class Slot09
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot19
        {
            public string name { get; set; }
        }

        public class Slot29
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public string contains_rune { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot39
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
        }

        public class Slot49
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Slot59
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }

        public class Slot69
        {
            public string name { get; set; }
        }

        public class Slot79
        {
            public string name { get; set; }
        }

        public class Slot89
        {
            public string name { get; set; }
        }

        public class Stash09
        {
            public string name { get; set; }
        }

        public class Stash19
        {
            public string name { get; set; }
        }

        public class Stash29
        {
            public string name { get; set; }
        }

        public class Stash39
        {
            public string name { get; set; }
        }

        public class Stash49
        {
            public string name { get; set; }
        }

        public class Stash59
        {
            public string name { get; set; }
        }

        public class Teleport09
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool can_cast { get; set; }
            public int cooldown { get; set; }
            public bool passive { get; set; }
            public int charges { get; set; }
        }

        public class Neutral09
        {
            public string name { get; set; }
            public int purchaser { get; set; }
            public bool passive { get; set; }
        }


    }
}