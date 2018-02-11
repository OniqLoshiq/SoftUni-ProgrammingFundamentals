import java.util.Scanner;

public class VovelDigit_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        if(input.matches("\\d+")){
            System.out.println("digit");
        } else if (input.equals("a") || input.equals("e")
                || input.equals("o") || input.equals("u")
                || input.equals("i") || input.equals("y")){
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }
    }
}
