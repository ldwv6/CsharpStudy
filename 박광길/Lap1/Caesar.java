import java.util.Scanner;

public class Caesar {
	public static void main(String[] args) {
		String A = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		String a = "";
		int adress;

		Scanner s = new Scanner(System.in);

		System.out.println("���� �Է� : ");
		String word = s.nextLine();
		System.out.println("���� �Է� :");
		int n = s.nextInt();
		n = n % 26;

		for (int i = 0; i < word.length(); i++) {
			String cnt = word.substring(i, i + 1);
			if (cnt.equals(" ")) {
				a = a + " ";
				continue;
			}
			adress = A.indexOf(cnt);
			a = a + A.substring(adress + n, adress + (n + 1));
		}
		System.out.println(a);
	}
}
