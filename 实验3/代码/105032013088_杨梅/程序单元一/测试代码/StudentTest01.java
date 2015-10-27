

import junit.framework.TestCase;

public class StudentTest01 extends TestCase
{

    Student testStudent;
    //此方法在执行每一个测试方法之前（测试用例）之前调用
    @Override
    protected void setUp() throws Exception
    {
        // TODO Auto-generated method stub
        super.setUp();
        testStudent = new Student("djm", "boy", 178, 24, "华东政法");
    }

    //此方法在执行每一个测试方法之后调用
    @Override
    protected void tearDown() throws Exception
    {
        // TODO Auto-generated method stub
        super.tearDown();
    }

    //测试用例，测试Person对象的getSex()方法
    public void testGetSex()
    {
        assertEquals("boy", testStudent.getSex());
        System.out.println("testGetSex()方法se成功");
        assertEquals(24, testStudent.getAge());
        System.out.println("testGetAge()方法測試成功");
    }
    
    //测试边界
    public void testboder(){
    	  System.out.println("58");
    	  System.out.println(testStudent.setAge(58));
    	  assertFalse(testStudent.setAge(58));
    }
    //测试容错性
    public void testfalse(){
    	  System.out.println("-5");
    	  assertFalse(testStudent.setAge(-5));
    }
}
