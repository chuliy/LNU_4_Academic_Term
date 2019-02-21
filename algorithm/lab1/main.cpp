#include "edge.h"
#include "graph.h"
#include "subset.h"

int16_t find(Subset subsets[],const int16_t i)
{
    if (subsets[static_cast<size_t>(i)].parent() != i)
        subsets[static_cast<size_t>(i)].setParent(find(subsets, subsets[static_cast<size_t>(i)].parent()));

    return subsets[static_cast<size_t>(i)].parent();

}

void Union(Subset subsets[], int16_t x, int16_t y)
{
    int16_t xroot = find(subsets, x);
    int16_t yroot = find(subsets, y);

    if (subsets[static_cast<size_t>(xroot)].rank() < subsets[static_cast<size_t>(yroot)].rank())
        subsets[static_cast<size_t>(xroot)].setParent(yroot);
    else if (subsets[static_cast<size_t>(xroot)].rank() > subsets[static_cast<size_t>(yroot)].rank())
        subsets[static_cast<size_t>(yroot)].setParent(xroot);

    else
    {
        subsets[static_cast<size_t>(yroot)].setParent(xroot);
        subsets[static_cast<size_t>(xroot)].setRank(subsets[static_cast<size_t>(xroot)].rank() +1 );
    }
}

int myComp(const void* a, const void* b)
{
    const Edge* a1 = static_cast<const Edge*>(a);
    const Edge* b1 = static_cast<const Edge*>(b);
    return a1->weight() > b1->weight();
}

void KruskalMST(Graph* graph)
{
    int16_t V = graph->vertices();
    size_t aaa = static_cast<size_t>(V);
    Edge *result = new Edge[aaa];
    int e = 0;
    int i = 0;

    qsort(graph->mEdgesArray, static_cast<size_t>(graph->edges()), sizeof(graph->mEdgesArray[0]), myComp);

     Subset *subsets = new Subset[static_cast<size_t>(V)];

    for (int16_t v = 0; v < V; ++v)
    {
        subsets[v].setParent(v);
        subsets[v].setRank(0);
    }

    while (e < V - 1)
    {

        Edge next_edge = graph->mEdgesArray[i++];

        int x = find(subsets, next_edge.firstVertex());
        int y = find(subsets, next_edge.secondVertex());

        if (x != y)
        {
            result[e++] = next_edge;
            Union(subsets, x, y);
        }
    }

    printf("Following are the edges in the constructed MST\n");
    for (i = 0; i < e; ++i)
        printf("%d -- %d == %f\n", result[i].firstVertex(), result[i].secondVertex(),
                                                result[i].weight());
    return;
}

int main()
{

    std::cout<<"input v and e"<<std::endl;
    int16_t V ;
    int16_t E ;
    std::cin>>V>>E;
    Graph *graph = new Graph(V,E);

    for(size_t i = 0; i != static_cast<size_t>(E) ; ++i)
    {
        std::cout<<"input first, second, weight"<<std::endl;
        int16_t f,s;
        double w;
        std::cin>>f>>s>>w;
        --f;--s;
        graph->mEdgesArray[i].setAll(f,s,w);
    }
    KruskalMST(graph);

    return 0;
}
