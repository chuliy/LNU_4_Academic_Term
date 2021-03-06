#ifndef GRAPH_H
#define GRAPH_H

#include <vector>

#include "edge.h"

class Graph
{
public:
    Graph(size_t vertices, size_t edges);

    size_t vertices() const;

    size_t edges() const;

    std::vector<Edge> mEdgesArray;
private:
    size_t mVertices;
    size_t mEdges;
};

#endif // GRAPH_H
