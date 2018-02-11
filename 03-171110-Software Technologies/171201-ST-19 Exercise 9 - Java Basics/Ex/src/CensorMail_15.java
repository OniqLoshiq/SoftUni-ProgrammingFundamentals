import java.util.Arrays;
import java.util.Scanner;

public class CensorMail_15 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String eMail = scanner.nextLine();
        String[] mail = eMail.split("@");
        String text = scanner.nextLine();
        String censor = "";
        for (int i = 0; i < mail[0].length(); i++) {
            censor += "*";
        }
        censor += "@" + mail[1];
        String output = text.replaceAll(eMail, censor);
        System.out.println(output);
    }
}
