#include "edge.h"
#include "graph.h"
#include "subset.h"
#include "logic.h"

int main()
{
    std::cout<<"input v and e"<<std::endl;
    size_t V ;
    size_t E ;
    std::cin>>V>>E;
    Graph *graph = new Graph(V,E);
    for(size_t i = 0; i != E ; ++i)
    {
        std::cout<<"input first, second, weight"<<std::endl;
        size_t f,s,w;
        std::cin>>f>>s>>w;
        graph->mEdgesArray[i].setAll(f,s,w);
    }
    Logic::Kruskal(graph);
    std::cout<<std::endl;
    return 0;
}
