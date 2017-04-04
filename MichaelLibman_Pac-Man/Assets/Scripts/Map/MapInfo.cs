//
// MapInfo.cs: 
//   Keeps all important map information
//
// Author:
//   Michael Libman
//

public class MapInfo 
{
    #region Members & Properties
    // consts

    // enums
    // Possible types of collision
    public enum CollisionTypes
    {
        WALL,
        EMPTY,
        PLAYER_SPAWN,
        ENEMY_SPAWN,
        TUNNEL,
        PELLET,
        POWER_PELLET,
        CHERRY,
        ENEMY
    }

    // structs
    // Types of tiles that can be parsed by the level creator
    public struct TileTypes 
    {
        public const string DELIMITER = " ";

        // Misc
        public const string  EMPTY = "0";
        public const string TUNNEL = "=";

        // Large Border Pieces
        public const string     TOP_LEFT_CORNER = "(";
        public const string    TOP_RIGHT_CORNER = ")";
        public const string            TOP_WALL = "-";
        public const string         BOTTOM_WALL = "_";
        public const string           LEFT_WALL = "{";
        public const string          RIGHT_WALL = "}";
        public const string  BOTTOM_LEFT_CORNER = "[";
        public const string BOTTOM_RIGHT_CORNER = "]";

        // Small Border Pieces
        public const string     SMALL_TOP_LEFT_CORNER = ".(";
        public const string    SMALL_TOP_RIGHT_CORNER = ".)";
        public const string  SMALL_BOTTOM_LEFT_CORNER = ".[";
        public const string SMALL_BOTTOM_RIGHT_CORNER = ".]";
        
        // Obstacles
        public const string     TOP_LEFT_CORNER_OBSTACLE = "!(";
        public const string    TOP_RIGHT_CORNER_OBSTACLE = "!)";
        public const string            TOP_WALL_OBSTACLE = "!-";
        public const string         BOTTOM_WALL_OBSTACLE = "!_";
        public const string           LEFT_WALL_OBSTACLE = "!{";
        public const string          RIGHT_WALL_OBSTACLE = "!}";
        public const string  BOTTOM_LEFT_CORNER_OBSTACLE = "![";
        public const string BOTTOM_RIGHT_CORNER_OBSTACLE = "!]";

        // Ghost House
        public const string                DOOR_GHOST_HOUSE = "^D";
        public const string     TOP_LEFT_CORNER_GHOST_HOUSE = "^(";
        public const string    TOP_RIGHT_CORNER_GHOST_HOUSE = "^)";
        public const string            TOP_WALL_GHOST_HOUSE = "^-";
        public const string         BOTTOM_WALL_GHOST_HOUSE = "^_";
        public const string           LEFT_WALL_GHOST_HOUSE = "^{";
        public const string          RIGHT_WALL_GHOST_HOUSE = "^}";
        public const string  BOTTOM_LEFT_CORNER_GHOST_HOUSE = "^[";
        public const string BOTTOM_RIGHT_CORNER_GHOST_HOUSE = "^]";

        // Spawners
        public const string       CHERRY_SPAWN = "&";
        public const string       PLAYER_SPAWN = "P";
        public const string       ENEMEY_SPAWN = "G";
        public const string       PELLET_SPAWN = "*";
        public const string POWER_PELLET_SPAWN = "+";
    }
    // public variables

    // private variables

    // properties
    #endregion
}
