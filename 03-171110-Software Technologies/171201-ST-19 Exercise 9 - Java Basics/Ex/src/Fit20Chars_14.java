import java.util.Scanner;

public class Fit20Chars_14 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        if(input.length() > 20){
            String output = input.substring(0, 20);
            System.out.println(output);
        } else if (input.length() == 20){
            System.out.println(input);
        } else {
            int numToFill = 20 - input.length();
            String output = "";
            output = String.format("%-" + numToFill + "s", output).replace(' ', '*');
            output = input.concat(output);
            System.out.println(output);
        }
    }
}
