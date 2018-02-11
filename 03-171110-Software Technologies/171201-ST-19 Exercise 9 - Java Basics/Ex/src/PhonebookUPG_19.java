import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUPG_19 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, String> phonebook = new TreeMap<>();

        while (true) {
            String[] input = scanner.nextLine().split("\\s+");

            if (input[0].equals("END")) {
                break;
            }

            if (input[0].equals("A")) {
                phonebook.put(input[1], input[2]);
            } else if (input[0].equals("ListAll")) {
                for (String s : phonebook.keySet()) {
                    System.out.printf("%s -> %s%n", s, phonebook.get(s));
                }
            } else if (input[0].equals("S")){
                if (phonebook.containsKey(input[1])) {
                    System.out.printf("%s -> %s%n", input[1], phonebook.get(input[1]));
                } else {
                    System.out.printf("Contact %s does not exist.%n", input[1]);
                }
            }
        }
    }
}
