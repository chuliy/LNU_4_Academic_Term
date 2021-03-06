#include "logic.h"

size_t Logic::find(std::vector<Subset> &subsets, const size_t i)
{
    if (subsets[i].parent() != i) 
        subsets[i].setParent(find(subsets, subsets[i].parent()));

    return subsets[i].parent();

}

void Logic::Union(std::vector<Subset> &subsets, size_t x, size_t y)
{

    size_t xroot = find(subsets, x);
    size_t yroot = find(subsets, y);

    if (subsets[xroot].rank() < subsets[yroot].rank())
        subsets[xroot].setParent(yroot);
    else if (subsets[xroot].rank() > subsets[yroot].rank())
        subsets[yroot].setParent(xroot);
    else
    {
        subsets[yroot].setParent(xroot);
        subsets[xroot].setRank(subsets[xroot].rank()+1);
    }
}

void Logic::Kruskal(Graph *graph)
{
    size_t V = graph->vertices();
    std::vector<Edge>result(V);
    size_t e = 0;
    size_t i = 0;

    struct less_than_key
    {
        inline bool operator() (const Edge& struct1, const Edge& struct2)
        {
            return (struct1.weight() < struct2.weight());
        }
    };
    std::sort(graph->mEdgesArray.begin(), graph->mEdgesArray.end(), less_than_key());
    std::vector<Subset> subsets(V);

    for (size_t v = 0; v < V; ++v)
    {
        subsets[v].setParent(v);
        subsets[v].setRank(0);
    }

    while (e < V - 1)
    {
        Edge next_edge = graph->mEdgesArray[i++];

        size_t x = find(subsets, next_edge.firstVertex());
        size_t y = find(subsets, next_edge.secondVertex());

        if (x != y)
        {
            result[e++] = next_edge;
            Union(subsets, x, y);
        }
    }
    size_t w = 0;
    for (i = 0; i < e; ++i)
    {
        w+=result[i].weight();
        std::cout<<result[i].firstVertex()<<" -- "<< result[i].secondVertex()<<"--"<<
                   result[i].weight()<<std::endl;
    }
    std::cout<<"weight = "<< w<<std::endl;
    return;
}

void Logic::Prims(Graph *graph)
{
    std::vector<bool> lVisited(graph->vertices(),false);
    std::vector<Edge> lEdges;
    std::vector<size_t> lVertex(graph->vertices());
    struct less_than_key
    {
        inline bool operator() (const Edge& struct1, const Edge& struct2)
        {
            return (struct1.weight() < struct2.weight());
        }
    };
    std::sort(graph->mEdgesArray.begin(), graph->mEdgesArray.end(), less_than_key());
    lVisited[0] = true;
    while(!checkBoolVector(lVisited))
    {
        for(auto localEdge : graph->mEdgesArray)
        {
            if((lVisited[localEdge.firstVertex()] && lVisited[localEdge.secondVertex()] == false)
                    ||(lVisited[localEdge.firstVertex()] == false && lVisited[localEdge.secondVertex()] == false)

        }
    }

}

bool Logic::checkBoolVector(const std::vector<bool> &vector)
{
    for(auto a : vector)
    {
        if(a == false)
        {
            return false;
        }
    }
    return true;
}
