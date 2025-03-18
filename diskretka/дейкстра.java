import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Main {

    static ArrayList path(int[] array, int start, int finish){

        ArrayList<Integer> path_list = new ArrayList<>();

        while (true){
            if (finish != start){
                path_list.add(finish);
                finish = array[finish];
            } else {
                Collections.reverse(path_list);
                return path_list;
            }
        }
    }


    static int find(int[] array, int[] visited){
        int min_of_array = Integer.MAX_VALUE;
        int index = 0;
        for (int i = 0; i < array.length; i++) {
            if (array[i] < min_of_array && array[i] != 0 && array[i] < Integer.MAX_VALUE && visited[i] == 0){
                min_of_array = array[i];
                index = i;
            }
        }
        return index;
    }

    static boolean found(int[] array, int target){
        for (int i = 0; i < array.length; i++){
            if (array[i] == target){
                return true;
            }
        }
        return false;
    }

    static void dijkstra(int[][] graph, int start){
        int[] distances = new int[graph.length];
        Arrays.fill(distances, Integer.MAX_VALUE);
        distances[0] = 0;

        int[] visited = new int[graph.length];
        Arrays.fill(visited, 0);

        int[] previous = new int[graph.length];
        Arrays.fill(previous, -1);

        int vertex = start;

        while (found(visited, 0)) {
            for (int i = 0; i < graph.length; i++){
                if(graph[vertex][i] != 0 && graph[vertex][i] + distances[vertex] < distances[i]){
                    distances[i] = graph[vertex][i] + distances[vertex];
                    previous[i] = vertex;
                }
            }
            visited[vertex] = 1;
            vertex = find(graph[vertex], visited);

            if (vertex == -1) continue;
        }

        System.out.println("distances: " + Arrays.toString(distances));
        System.out.println("previous: " + Arrays.toString(previous));
        Scanner sc = new Scanner(System.in);
        System.out.print("finish: ");
        int finish = sc.nextInt();

        ArrayList path_list = path(previous, -1, finish);

        for (int i = 0; i < path_list.size(); i++){
            System.out.print(path_list.get(i));
            if (i < path_list.size() - 1){
                System.out.print(" -> ");
            }
        }
        System.out.println();
        System.out.printf("length: %d", distances[finish]);
    }


    public static void main(String[] args) {

        int[][] graph = {{0, 3, 1, 3, 0, 0},
                         {3, 0, 4, 0, 0, 0},
                         {1, 4, 0, 0, 7, 5},
                         {3, 0, 0, 0, 0, 2},
                         {0, 0, 7, 0, 0, 4},
                         {0, 0, 5, 2, 4, 0}};

        int[][] graph2 = {{0, 1, 2, 4},
                          {1, 0, 1, 2},
                          {2, 1, 0, 1},
                          {4, 2, 1, 0}};

        int start = 0;

        dijkstra(graph2, start);
    }
}
