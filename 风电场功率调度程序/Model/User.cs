namespace 风电场功率调度程序
{
    public class User
    {
      public User()
      {
         this.UserName = "系统内置用户";
        this.UserType =  0; 
            ; }
      public string UserName { get; set; }
      public string UserPassword { get; set; }
      public int UserType { get; set; }
      public int IsDelete { get; set; }
      public int IsVisiable { get; set; }
         
    }
}