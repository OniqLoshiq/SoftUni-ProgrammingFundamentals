import java.util.Scanner;

public class ReverseString_13 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        System.out.println(new StringBuffer(input).reverse().toString());
    }
}
