import java.util.HashMap;
import java.util.Scanner;

public class Phonebook_18 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        HashMap<String, String> phonebook = new HashMap<>();

        while (true) {
            String[] input = scanner.nextLine().split("\\s+");

            if (input[0].equals("END")) {
                break;
            }

            if (input[0].equals("A")) {
                phonebook.put(input[1], input[2]);
            } else if (input[0].equals("S")) {
                if (phonebook.containsKey(input[1])) {
                    System.out.printf("%s -> %s%n", input[1], phonebook.get(input[1]));
                } else {
                    System.out.printf("Contact %s does not exist.%n", input[1]);
                }
            }
        }
    }
}
