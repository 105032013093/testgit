

import junit.framework.TestCase;

public class StudentTest01 extends TestCase
{

    Student testStudent;
    //�˷�����ִ��ÿһ�����Է���֮ǰ������������֮ǰ����
    @Override
    protected void setUp() throws Exception
    {
        // TODO Auto-generated method stub
        super.setUp();
        testStudent = new Student("djm", "boy", 178, 24, "��������");
    }

    //�˷�����ִ��ÿһ�����Է���֮�����
    @Override
    protected void tearDown() throws Exception
    {
        // TODO Auto-generated method stub
        super.tearDown();
    }

    //��������������Person�����getSex()����
    public void testGetSex()
    {
        assertEquals("boy", testStudent.getSex());
        System.out.println("testGetSex()����se�ɹ�");
        assertEquals(24, testStudent.getAge());
        System.out.println("testGetAge()�����yԇ�ɹ�");
    }
    
    //���Ա߽�
    public void testboder(){
    	  System.out.println("58");
    	  System.out.println(testStudent.setAge(58));
    	  assertFalse(testStudent.setAge(58));
    }
    //�����ݴ���
    public void testfalse(){
    	  System.out.println("-5");
    	  assertFalse(testStudent.setAge(-5));
    }
}
