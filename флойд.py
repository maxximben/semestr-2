import math

graph = [[0, 20, 10, 0, 0, 0], 
         [0, 0, 0, 33, 20, 0], 
         [0, 0, 0, 10, 50, 0], 
         [0, 0, 0, 0, 0, 1],
         [0, 0, 0, 5, 0, -2],
         [0, 0, 0, 0, 0, 0]]


def floyd(graph):
    length = len(graph)
    D = [[graph[i][j] if graph[i][j] != 0 else math.inf 
          for j in range(length)] for i in range(length)]

    for i in range(length):
        for j in range(length):
            if graph[i][j] != 0:
                D[i][j] = graph[i][j]
            elif graph[i][j] == 0:
                D[i][j] = math.inf

    for i in range(length):
        for j in range(length):
            for k in range(length):
                if D[i][k] + D[k][j] < D[i][j]:
                    D[i][j] = D[i][k] + D[k][j]

    for i in range(length):
        if D[i][i] < 0:
            print("negative weight cycle detected")
            exit()

    for i in D:
        print(i)



floyd(graph)
