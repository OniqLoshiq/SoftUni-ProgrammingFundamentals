import java.util.Arrays;
import java.util.Scanner;

public class BombNums_12 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] nums = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int[] bomb = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();

        boolean[] checker = new boolean[nums.length];
        int sum = 0;

        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == bomb[0] && checker[i] == false){
                checker[i] = true;

                for (int j = 1; j <= bomb[1]; j++) {
                    if(i - j >= 0){
                        checker[i - j] = true;
                    }
                    if (i + j < nums.length) {
                        checker[i + j] = true;
                    }
                }
            }
        }
        for (int i = 0; i < nums.length; i++) {
          if(!checker[i]) {
              sum += nums[i];
          }
        }
        System.out.println(sum);
    }
}
