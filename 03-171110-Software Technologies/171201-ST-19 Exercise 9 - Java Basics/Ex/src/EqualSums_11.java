import java.util.Arrays;
import java.util.Scanner;

public class EqualSums_11 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] nums = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int sumLeft = 0;
        int sumRight = 0;
        boolean isEqualSum = true;

        if (nums.length == 1) {
            System.out.println(0);
            isEqualSum = false;
        } else {
            for (int i = 0; i < nums.length; i++) {
                for (int j = 0; j < i; j++) {
                    sumLeft += nums[j];
                }
                for (int j = i + 1; j < nums.length; j++) {
                    sumRight += nums[j];
                }
                if (sumLeft == sumRight) {
                    System.out.println(i);
                    isEqualSum = false;
                    break;
                }
                sumLeft = 0;
                sumRight = 0;
            }
        }
        if (isEqualSum) {
            System.out.println("no");
        }
    }
}
