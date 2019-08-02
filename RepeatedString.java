import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(String s, long n) {        
        String substr = new String();
        long lastIndex = 0;
        long length = s.length();
        long remainder = 0, quotient = 0, acounter = 0, acounter2 = 0, counter = 0;

        for(int i = 0; i<s.length(); i++){
            char exa = s.charAt(i);
            if(exa == 'a'){
                acounter++;
            }
        }

        quotient = n / length ;
        remainder = n % length ;
        counter = acounter * quotient;
        lastIndex = remainder;
        substr = s.substring(0, (int) lastIndex);

        for(int i=0; i<substr.length(); i++){
            char exa = s.charAt(i);
            if(exa == 'a'){
                acounter2++;
            }
        }
        counter += acounter2;
        return counter;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        long n = scanner.nextLong();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        long result = repeatedString(s, n);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
