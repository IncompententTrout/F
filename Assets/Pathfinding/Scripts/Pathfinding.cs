using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding 
{

    private Grid<PathNode> grid;
    private Grid<PathNode> openList;
    private Grid<PathNode> closedList;

    public Pathfinding(int width, int height) 
    {
        grid = new Grid<PathNode>(width, height, 10f, Vector3.zero, (Grid<PathNode> g, int x, int y) => new PathNode(g, x, y));
    }

    private List<PathNode> FindPath(int startX, int startY, int endX, int endY)
    {
        PathNode startNode = grid.GetGridObject(startX, startY);
        
        openList = new List<PathNode>() { startNode };
        closedList = new List<PathNode>();
    }

}
