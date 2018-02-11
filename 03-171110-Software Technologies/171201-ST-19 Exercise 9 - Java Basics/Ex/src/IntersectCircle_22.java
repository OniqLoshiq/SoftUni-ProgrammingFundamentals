import java.util.Arrays;
import java.util.Scanner;

class Circle {
    private int x;
    private int y;
    private int radius;

    public Circle(int x, int y, int radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public int getRadius() {
        return radius;
    }
}

public class IntersectCircle_22 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] input1 = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int[] input2 = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();

        Circle circle1 = new Circle(input1[0], input1[1], input1[2]);
        Circle circle2 = new Circle(input2[0], input2[1], input2[2]);

        boolean intersect = isInside(circle1, circle2);
        if(intersect){
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

    private static boolean isInside(Circle circle1, Circle circle2) {
        boolean isInside = false;
        double d1 = Math.sqrt(Math.pow(circle1.getX(), 2) + Math.pow(circle1.getY(), 2));
        double d2 = Math.sqrt(Math.pow(circle2.getX(), 2) + Math.pow(circle2.getY(), 2));
        double d = Math.abs(d1 - d2);
        if(d <= circle1.getRadius() + circle2.getRadius()){
            isInside = true;
        }
        return isInside;
    }

}
