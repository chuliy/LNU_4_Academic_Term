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
        subsets[xroot].setRank(subsets[xroot].rank());
    }
}

void Logic::Kruskal(Graph *graph)
{
    size_t V = graph->vertices();
    Edge *result = new Edge[V];
    size_t e = 0;
    size_t i = 0;

    qsort(graph->mEdgesArray, graph->edges(), sizeof(graph->mEdgesArray[0]), myComp);

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

    std::cout<<"Following are the edges in the constructed MST\n";
    for (i = 0; i < e; ++i)
        std::cout<<" -- %d == %f\n", result[i].firstVertex()<<" -- ", result[i].secondVertex(),
                                                result[i].weight());
    return;
}


int myComp(const void *a, const void *b)
{
    const Edge* a1 = static_cast<const Edge*>(a);
    const Edge* b1 = static_cast<const Edge*>(b);
    return a1->weight() > b1->weight()
}
