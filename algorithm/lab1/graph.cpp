#include "graph.h"


Graph::Graph(size_t vertices, size_t edges)
    :mVertices(vertices),mEdges(edges)
{
    mEdgesArray = new Edge[mEdges];
}

size_t Graph::vertices() const
{
    return mVertices;
}

size_t Graph::edges() const
{
    return mEdges;
}
