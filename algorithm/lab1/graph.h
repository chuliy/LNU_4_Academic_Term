#ifndef GRAPH_H
#define GRAPH_H

#include "edge.h"
class Graph
{
public:
    Graph(int16_t vertices, int16_t edges);

    int16_t vertices() const;

    int16_t edges() const;
    Edge* mEdgesArray;
private:
    int16_t mVertices;
    int16_t mEdges;

};

#endif // GRAPH_H
