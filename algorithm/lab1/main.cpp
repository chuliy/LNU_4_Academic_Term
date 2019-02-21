#include "edge.h"
#include "graph.h"
#include "subset.h"



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
