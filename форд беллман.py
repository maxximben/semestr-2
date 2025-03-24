import math

def path(array, start, finish):
    path_list = []
    while(True):
        if finish != start:
            path_list.append(finish)
            finish = array[finish]
        else:
            path_list.reverse()
            return path_list


def ford_bellman(graph, start):
    distances = [math.inf]*len(graph)
    distances[0] = 0
    previous = [0]*len(graph)
    previous[0] = -1

    for _ in range(len(graph)):
        for i in range(len(graph)):
            for j in range(len(graph[i])):
                if graph[i][j] == 0 or graph[i][j] == math.inf:
                    continue
                if distances[i] + graph[i][j] < distances[j]:
                    distances[j] = distances[i] + graph[i][j]
                    previous[j] = i



    for i in range(len(graph)):
        for j in range(len(graph[i])):
            if graph[i][j] != 0 and distances[i] != math.inf:
                if distances[i] + graph[i][j] < distances[j]:
                    print("negative weight cycle detected")
                    exit()

    print(distances)
    print(previous)

    fin = int(input("finish: "))

    path_list = path(previous, -1, fin)

    for i in range(len(path_list)):
        print(path_list[i], end='')
        if i < len(path_list)-1:
            print(" -> ", end='')
    print('')
    print(f"length: {distances[fin]}")



graph = [[0, 20, 10, 0, 0, 0], 
         [0, 0, 0, 33, 20, 0], 
         [0, 0, 0, 10, 50, 0], 
         [0, 0, 0, 0, 0, 1],
         [0, 0, 0, -20, 0, 1],
         [0, 0, 0, 0, 0, 0]]


start = 0

ford_bellman(graph, start)
