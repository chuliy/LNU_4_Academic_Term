#include "graph.h"


Graph::Graph(int16_t vertices, int16_t edges)
    :mVertices(vertices),mEdges(edges)
{
    mEdgesArray = new Edge[static_cast<size_t>(mEdges)];
}

int16_t Graph::vertices() const
{
    return mVertices;
}

int16_t Graph::edges() const
{
    return mEdges;
}
