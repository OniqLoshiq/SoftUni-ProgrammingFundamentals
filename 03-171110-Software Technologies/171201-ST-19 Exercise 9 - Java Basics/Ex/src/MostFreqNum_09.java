import java.util.Arrays;
import java.util.Scanner;

public class MostFreqNum_09 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] seq = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int num = 0;
        int counter = 1;
        int bestCounter = 1;
        boolean[] isEqual = new boolean[seq.length];
        for (int i = 0; i < isEqual.length; i++) {
            isEqual[i] = false;
        }

        for (int i = 0; i < seq.length; i++) {
            if (!isEqual[i]) {
                for (int j = i + 1; j < seq.length; j++) {
                    if (seq[i] == seq[j]) {
                        counter++;
                        isEqual[j] = true;
                    }
                }
                if (counter > bestCounter) {
                    bestCounter = counter;
                    num = seq[i];
                }
            }
            counter = 1;
        }
        if(bestCounter == 1) num = seq[0];
        System.out.println(num);

    }
}

