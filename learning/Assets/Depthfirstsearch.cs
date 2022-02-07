using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depthfirstsearch : MonoBehaviour
{
    public Node rootNode;
    public Node target;

    private void Start()
    {
        int stepCount = DFS(target);
        if(stepCount > -1)
        {
            Debug.Log(target.name + "was found in" + stepCount + "steps");
        }
        else
        {

                Debug.Log(target.name + "was not found.");
            }
    }

    public int DFS(Node targetNode)
    {
        Stack stack = new Stack(); // stack the nodes last one stacked is first visited 
        List<Node> visitedNodes = new List<Node>(); // tracks visited nodes

        stack.Push(rootNode); // push root node to the stack

        while (stack.Count > 0)
        {
            Node node = (Node)stack.Pop(); // get the node on top of the stack
            visitedNodes.Add(node);

            foreach(Node child in node.children) //loop through the children of the nodes
            {
                if(visitedNodes.Contains(child) == false && stack.Contains(child) == false)
                        {
                    if(child == targetNode)
                    {
                        return visitedNodes.Count; // return no. of visited nodes
                    }
                    stack.Push(child);
                }
            }
        }
        return -1;
    }
}
