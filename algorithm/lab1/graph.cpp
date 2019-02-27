#include "graph.h"


Graph::Graph(size_t vertices, size_t edges)
    :mVertices(vertices),mEdges(edges)
{
    for (size_t i = 0 ; i < mEdges; ++i)
    {
        mEdgesArray.push_back(Edge());
    }
}

size_t Graph::vertices() const
{
    return mVertices;
}

size_t Graph::edges() const
{
    return mEdges;
}
