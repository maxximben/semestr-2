import numpy as np
from collections import deque

def bfs(graph, source, sink, parent):
    visited = [False] * len(graph)
    queue = deque()
    queue.append(source)
    visited[source] = True
    
    while queue:
        u = queue.popleft()
        for v in range(len(graph)):
            if not visited[v] and graph[u][v] > 0:
                queue.append(v)
                visited[v] = True
                parent[v] = u
                if v == sink:
                    return True
    return False

def ford_fulkerson(graph, source, sink):
    residual_graph = np.array(graph, dtype=float)
    parent = [-1] * len(graph)
    max_flow = 0

    while bfs(residual_graph, source, sink, parent):
        path_flow = float("Inf")
        s = sink

        while s != source:
            path_flow = min(path_flow, residual_graph[parent[s]][s])
            s = parent[s]
        
        max_flow += path_flow
        
        v = sink
        while v != source:
            u = parent[v]
            residual_graph[u][v] -= path_flow
            residual_graph[v][u] += path_flow
            v = parent[v]
    
    return max_flow

graph = [
    [0, 17, 18, 19, 0, 0, 0],
    [0, 0, 15, 0, 17, 22, 0],
    [0, 0, 0, 0, 0, 21, 0],
    [0, 0, 14, 0, 0, 20, 0],
    [0, 0, 0, 15, 0, 0, 20],
    [0, 0, 0, 0, 18, 0, 25], 
    [0, 0, 0, 0, 0, 0, 0]
]

source = 0
sink = 6

max_flow = ford_fulkerson(graph, source, sink)
print(f"Максимальный поток из источкика {source} в сток {sink} равен: {max_flow}")
