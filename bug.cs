public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0 || b == 0) {
            return 0; // This will cause an exception if a or b are zero
        }
        return a / b; // potential DivideByZeroException
    }
}