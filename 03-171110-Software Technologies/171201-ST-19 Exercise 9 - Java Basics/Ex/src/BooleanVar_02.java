import java.util.Scanner;

public class BooleanVar_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        boolean bool1 = Boolean.parseBoolean(scanner.nextLine());

        if(bool1){
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
