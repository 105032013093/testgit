
public class Student
{

    private String name;
    private String sex;
    private int high;
    private int age;
    private String school;
    
    public Student(String name, String sex ,int high, int age, String school)
    {
        this.name = name;
        this.sex = sex;
        this.high = high;
        this.age = age;
        this.school = school;
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public String getSex()
    {
        return sex;
    }
    public void setSex(String sex)
    {
        this.sex = sex;
    }
    public int getHigh()
    {
        return high;
    }
    public void setHigh(int high)
    {
        this.high = high;
    }
    public int getAge()
    {
        return age;
    }
    public boolean setAge(int age)
    {
        if (age >25)
        {
            return false;
        }
        else if (age>0)
        {
            this.age = age;
            return true;
        } 
        else {
        	System.out.println("数据错误,不能为负数");
        	return false;
        }
    }
    

    public String getSchool()
    {
        return school;
    }
    public void setSchool(String school)
    {
        this.school = school;
    }
    
}
