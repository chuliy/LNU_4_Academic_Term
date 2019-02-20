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
    Edge *result = new Edge[aaa]; // Tnis will store the resultant MST
    int e = 0; // An index variable, used for result[]
    int i = 0; // An index variable, used for sorted edges

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

        // If including this edge does't cause cycle,
        // include it in result and increment the index
        // of result for next edge
        if (x != y)
        {
            result[e++] = next_edge;
            Union(subsets, x, y);
        }
        // Else discard the next_edge
    }

    // print the contents of result[] to display the
    // built MST
    printf("Following are the edges in the constructed MST\n");
    for (i = 0; i < e; ++i)
        printf("%d -- %d == %f\n", result[i].firstVertex(), result[i].secondVertex(),
                                                result[i].weight());
    return;
}

// Driver program to test above functions
int main()
{
    /* Let us create following weighted graph
            10
        0--------1
        | \	     |
       6|   5\   |15
        |	   \ |
        2--------3
            4	 */
    int16_t V = 4; // Number of vertices in graph
    int16_t E = 5; // Number of edges in graph
    Graph *graph = new Graph(V,E);


    // add edge 0-1
    graph->mEdgesArray[0].setFirstVertex(0);
    graph->mEdgesArray[0].setSecondVertex(1);
    graph->mEdgesArray[0].setWeight(10);

    // add edge 0-2
    graph->mEdgesArray[1].setFirstVertex(0);
    graph->mEdgesArray[1].setSecondVertex(2);
    graph->mEdgesArray[1].setWeight(6);

    // add edge 0-3
    graph->mEdgesArray[2].setFirstVertex(0);
    graph->mEdgesArray[2].setSecondVertex(3);
    graph->mEdgesArray[2].setWeight(5);

    // add edge 1-3
    graph->mEdgesArray[3].setFirstVertex(1);
    graph->mEdgesArray[3].setSecondVertex(3);
    graph->mEdgesArray[3].setWeight(15);

    // add edge 2-3
    graph->mEdgesArray[4].setFirstVertex(2);
    graph->mEdgesArray[4].setSecondVertex(3);
    graph->mEdgesArray[4].setWeight(4);

    KruskalMST(graph);

    return 0;
}
