import java.util.Arrays;
import java.util.Scanner;

public class MaxSeq_07 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] seq = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int start = 0;
        int bestStart = 0;
        int counter = 1;
        int bestCounter = 1;

        for (int i = 1; i < seq.length; i++) {
            if (seq[i] == seq[i - 1]) {
                counter++;
                if (counter > bestCounter) {
                    bestCounter = counter;
                    bestStart = start;
                }
            } else {
                counter = 1;
                start = i;
            }
        }
        for (int i = 0; i < bestCounter; i++) {
            System.out.print(seq[bestStart + i]);
            if(i != bestCounter - 1){
                System.out.print(" ");
            }
        }
    }
}
