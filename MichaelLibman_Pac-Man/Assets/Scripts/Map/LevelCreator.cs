//
// LevelCreator.cs: 
//   Handle the level creation based on 
//   the map text file
//
// Author:
//   Michael Libman
//

using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public class LevelCreator : MonoBehaviour 
{
    #region Members & Properties
    // consts
    private const string MAP_FILE_EXTENSION = ".txt";

    // enums

    // structs

    // public variables

    // private variables
    [SerializeField]
    private int m_TileSize = 8;                  // Size of the each tile
    [SerializeField]
    private string m_MapFolderLocation = "Maps"; // Folder location to find the map text file
    [SerializeField]
    private string m_MapTextFileName = "Map";    // Map file name without extension

    private GameObject m_LevelGameObject;

    // properties
    #endregion

    #region Unity API
    void Start()
    {
        string mapContents = ReadMap();         // Load map into memory
        string[][] map = ParseMap(mapContents); // Parse map into a 2D array

        GenerateLevel(map);                     // Generate the map
    }
    #endregion

    #region Private Methods
    /// <summary>
    /// Open and read the map file.
    /// </summary>
    /// <returns>Returns the contents of the file</returns>
    private string ReadMap()
    {
        return File.ReadAllText(Application.dataPath + "\\" + m_MapFolderLocation + "\\" + m_MapTextFileName + MAP_FILE_EXTENSION);
    }

    /// <summary>
    /// Parse the map into rows and columns to use
    /// for tile generation.
    /// </summary>
    /// <param name="map">Map information from the map text file</param>
    /// <returns>Fully parsed map in 2D string array</returns>
    private string[][] ParseMap(string map)
    {
        string[] mapRows = Regex.Split(map, "\r\n");    // Split map into rows based on return symbols
        int totalRows = mapRows.Length;                 // Count number of rows in map

        string[][] parsedMap = new string[totalRows][]; // Initialize the parsed map with total row count

        // Rip through rows to parse columns and tile data
        for (int row = 0; row < mapRows.Length; row++)
        {
            string[] columns = Regex.Split(mapRows[row], MapInfo.TileTypes.DELIMITER); // Split columns by the delimiter and put into row

            parsedMap[row] = columns; // Append columns into its row in the parsed map
        }

        return parsedMap; // Return parsed map
    }

    /// <summary>
    /// Generate the map based of the parsed 2D array.
    /// </summary>
    /// <param name="map">The parsed 2D array map</param>
    private void GenerateLevel(string[][] map)
    {
        int totalRows = map.Length; // Total rows of the map

        m_LevelGameObject = new GameObject(m_MapTextFileName); // Create a parent gameobject for the map to attach to - This is to stay organized

        // Ripe through all rows in map
        for (int row = 0; row < totalRows; row++)
        {
            int totalColumns = map[row].Length; // Total columns in row

            GameObject rowGameObject = new GameObject("Row_" + row.ToString()); // Create a parent gameobject for columns to attach to
            rowGameObject.transform.parent = m_LevelGameObject.transform;       // Attach row gameobject to map parent

            // Rip through all columns in row
            for (int column = 0; column < totalColumns; column++)
            {
                int yPosition = -row * m_TileSize;   // Set the y position of the current tile
                int xPosition = column * m_TileSize; // Set the x position of the current tile
                string tileType = map[row][column];  // Set the type of tile to create

                GameObject columnGameObject = new GameObject("Column_" + column.ToString()); // Create a parent gameobject for tiles to attach to
                columnGameObject.transform.parent = rowGameObject.transform;                 // Attach column gameobject to its specific row

                GameObject tileGameObject = new GameObject();                   // Create a tile gameobject
                tileGameObject.transform.parent = columnGameObject.transform;   // Attach tile to specific row / column gameobject
                tileGameObject.transform.position = new Vector2(xPosition, yPosition); // Set the position of the tile

                CreateTile(tileType, tileGameObject);  // Create the tile
            }
        }
    }

    /// <summary>
    /// Creates a tile for the gameobject
    /// </summary>
    /// <param name="tileType">The type of tile to create</param>
    /// <param name="tileGameObject">Gameobject that will be set a specific tile type</param>
    private void CreateTile(string tileType, GameObject tileGameObject)
    {
        switch (tileType)
        {
            // Misc
            case MapInfo.TileTypes.EMPTY:
                tileGameObject.AddComponent<EmptyTile>();
                break;

            case MapInfo.TileTypes.TUNNEL:
                tileGameObject.AddComponent<TunnelTile>();
                break;


            // Large Border Pieces
            case MapInfo.TileTypes.TOP_LEFT_CORNER:
                tileGameObject.AddComponent<TopLeftCornerTile>();
                break;

            case MapInfo.TileTypes.TOP_RIGHT_CORNER:
                tileGameObject.AddComponent<TopRightCornerTile>();
                break;

            case MapInfo.TileTypes.TOP_WALL:
                tileGameObject.AddComponent<TopWallTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_WALL:
                tileGameObject.AddComponent<BottomWallTile>();
                break;

            case MapInfo.TileTypes.LEFT_WALL:
                tileGameObject.AddComponent<LeftWallTile>();
                break;

            case MapInfo.TileTypes.RIGHT_WALL:
                tileGameObject.AddComponent<RightWallTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_LEFT_CORNER:
                tileGameObject.AddComponent<BottomLeftCornerTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_RIGHT_CORNER:
                tileGameObject.AddComponent<BottomRightCornerTile>();
                break;


            // Small Border Pieces
            case MapInfo.TileTypes.SMALL_TOP_LEFT_CORNER:
                tileGameObject.AddComponent<SmallTopLeftCornerTile>();
                break;

            case MapInfo.TileTypes.SMALL_TOP_RIGHT_CORNER:
                tileGameObject.AddComponent<SmallTopRightCornerTile>();
                break;

            case MapInfo.TileTypes.SMALL_BOTTOM_LEFT_CORNER:
                tileGameObject.AddComponent<SmallBottomLeftCornerTile>();
                break;

            case MapInfo.TileTypes.SMALL_BOTTOM_RIGHT_CORNER:
                tileGameObject.AddComponent<SmallBottomRightCornerTile>();
                break;

            
            // Obstacles
            case MapInfo.TileTypes.TOP_LEFT_CORNER_OBSTACLE:
                tileGameObject.AddComponent<TopLeftCornerObstacleTile>();
                break;

            case MapInfo.TileTypes.TOP_RIGHT_CORNER_OBSTACLE:
                tileGameObject.AddComponent<TopRightCornerObstacleTile>();
                break;

            case MapInfo.TileTypes.TOP_WALL_OBSTACLE:
                tileGameObject.AddComponent<TopWallObstacleTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_WALL_OBSTACLE:
                tileGameObject.AddComponent<BottomWallObstacleTile>();
                break;

            case MapInfo.TileTypes.LEFT_WALL_OBSTACLE:
                tileGameObject.AddComponent<LeftWallObstacleTile>();
                break;

            case MapInfo.TileTypes.RIGHT_WALL_OBSTACLE:
                tileGameObject.AddComponent<RightWallObstacleTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_LEFT_CORNER_OBSTACLE:
                tileGameObject.AddComponent<BottomLeftCornerObstacleTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_RIGHT_CORNER_OBSTACLE:
                tileGameObject.AddComponent<BottomRightCornerObstacleTile>();
                break;


            // Ghost House
            case MapInfo.TileTypes.DOOR_GHOST_HOUSE:
                tileGameObject.AddComponent<DoorGhostHouseTile>();
                break;

            case MapInfo.TileTypes.TOP_LEFT_CORNER_GHOST_HOUSE:
                tileGameObject.AddComponent<TopLeftCornerGhostHouseTile>();
                break;

            case MapInfo.TileTypes.TOP_RIGHT_CORNER_GHOST_HOUSE:
                tileGameObject.AddComponent<TopRightCornerGhostHouseTile>();
                break;

            case MapInfo.TileTypes.TOP_WALL_GHOST_HOUSE:
                tileGameObject.AddComponent<TopWallGhostHouseTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_WALL_GHOST_HOUSE:
                tileGameObject.AddComponent<BottomWallGhostHouseTile>();
                break;

            case MapInfo.TileTypes.LEFT_WALL_GHOST_HOUSE:
                tileGameObject.AddComponent<LeftWallGhostHouseTile>();
                break;

            case MapInfo.TileTypes.RIGHT_WALL_GHOST_HOUSE:
                tileGameObject.AddComponent<RightWallGhostHouseTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_LEFT_CORNER_GHOST_HOUSE:
                tileGameObject.AddComponent<BottomLeftCornerGhostHouseTile>();
                break;

            case MapInfo.TileTypes.BOTTOM_RIGHT_CORNER_GHOST_HOUSE:
                tileGameObject.AddComponent<BottomRightCornerGhostHouseTile>();
                break;

            // Spawners
            case MapInfo.TileTypes.CHERRY_SPAWN:
                tileGameObject.AddComponent<CherrySpawnerTile>();
                break;

            case MapInfo.TileTypes.PLAYER_SPAWN:
                tileGameObject.AddComponent<PlayerSpawnerTile>();
                break;

            case MapInfo.TileTypes.ENEMEY_SPAWN:
                tileGameObject.AddComponent<EnemySpawnerTile>();
                break;

            case MapInfo.TileTypes.PELLET_SPAWN:
                tileGameObject.AddComponent<PelletSpawnerTile>();
                break;

            case MapInfo.TileTypes.POWER_PELLET_SPAWN:
                tileGameObject.AddComponent<PowerPelletSpawnerTile>();
                break;
        }
    }
	#endregion
}
