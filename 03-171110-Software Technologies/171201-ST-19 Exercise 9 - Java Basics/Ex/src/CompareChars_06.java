import java.util.Arrays;
import java.util.Scanner;

public class CompareChars_06 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] firstArr = scanner.nextLine().split("\\s+");
        String[] secondArr = scanner.nextLine().split("\\s+");
        boolean isEqual = false;

        int num = Math.min(firstArr.length, secondArr.length);
        for (int i = 0; i < num; i++) {
            if(firstArr[i].compareTo(secondArr[i]) > 0){
                System.out.println(Arrays.toString(secondArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
                System.out.println(Arrays.toString(firstArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
                isEqual = false;
                break;
            } else if (firstArr[i].compareTo(secondArr[i]) < 0){
                System.out.println(Arrays.toString(firstArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
                System.out.println(Arrays.toString(secondArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
                isEqual = false;
                break;
            } else {
                isEqual = true;
            }
        }
        if(isEqual){
            if(firstArr.length <= secondArr.length){
                System.out.println(Arrays.toString(firstArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
                System.out.println(Arrays.toString(secondArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
            } else {
                System.out.println(Arrays.toString(secondArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
                System.out.println(Arrays.toString(firstArr)
                        .replaceAll("\\[","")
                        .replaceAll("]", "")
                        .replaceAll(",\\s",""));
            }
        }
    }
}
