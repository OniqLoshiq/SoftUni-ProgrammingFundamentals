import java.util.Scanner;

public class ReverseChars_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String output = "";
        for (int i = 0; i < 3; i++) {
            output += scanner.nextLine();
        }
        String reversedStr = new StringBuffer(output).reverse().toString();
        System.out.println(reversedStr);
    }
}
