import math

graph = [[0, 3, 1, 3, 0, 0], 
         [3, 0, 4, 0, 0, 0], 
         [1, 4, 0, 0, 7, 5], 
         [3, 0, 0, 0, 0, 2],
         [0, 0, 7, 0, 0, 4],
         [0, 0, 5, 2, 4, 0]]

graph = [[0, 1, 8, 6], 
         [1, 0, 1, 8], 
         [8, 1, 0, 2], 
         [6, 8, 2, 0]]

def find(array, visited):
    min_array = math.inf
    i_min_array = -1
    for i in range(len(array)):
        if array[i] != 0 and array[i] < math.inf and array[i] < min_array and visited[i] == False:  
            min_array = array[i]
            i_min_array = i
    return i_min_array

def path(array, start, finish):
    path_list = []
    while(True):
        if finish != start:
            path_list.append(finish)
            finish = array[finish]
        else:
            path_list.reverse()
            return path_list

def dijkstra(graph, start):
    l = len(graph)
    visited = [False] * l
    previous = [-1] * l
    distances = [math.inf] * l
    distances[start] = 0

    vertex = start

    while 0 in visited:
        for i in range(l):
            if graph[vertex][i] != 0 and graph[vertex][i] + distances[vertex] < distances[i]:
                distances[i] = graph[vertex][i] + distances[vertex]
                previous[i] = vertex
 
        visited[vertex] = True
        vertex = find(graph[vertex], visited)
        if vertex == -1:
            continue
        
        
    print("distances:", distances)
    print("previous", previous)

    fin = int(input("finish: "))

    path_list = path(previous, -1, fin)

    for i in range(len(path_list)):
        print(path_list[i], end='')
        if i < len(path_list)-1:
            print(" -> ", end='')
    print('')
    print(f"length: {distances[fin]}")

start = 0

dijkstra(graph, start)
