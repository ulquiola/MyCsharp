# MyCsharp
1、	编写一个Windows应用程序，实现从白色到绿色渐变的背景，然后接收一个字符串，将字符串中的所有小写字母转变为大写字母。
2、编写一个Windows应用程序，利用ListView控件实现如下窗体
3、创建一个Windows应用程序，请设计一个简易的计算器，只需实现“+”、“-”、“*”、“/”运算。
4、创建一个Windows应用程序，请设计一个用户登录界面，窗体上有两个标签Label1和Label2，它们的Text属性分别为用户名和密码；文本框TextBox1和TextBox2的Text属性都为空，TextBox2的PasswordChar属性为“*”；命令按钮Button1的Text属性为“登录”。为TextBox1的KeyPress事件添加事件处理程序，当在TextBox1中输入回车键时（它的ASCII码为13,可以用e.KeyChar==13来判断，使TextBox2获得焦点（使用Foucs方法）。为TextBox2的KeyPress事件添加事件处理程序，当在TextBox2中输入回车键时（它的ASCII码为13,可以用e.KeyChar==13来判断），使Button1获得焦点（使用Foucs方法）。为Button1的Click事件添加事件处理程序，当输入的用户名为“admin”并且密码为“123”时，显示消息框“欢迎你！”，否则显示消息框“用户名或密码错误，请重试！”(使用MessageBox.Show("用户名或密码错误，请重试！");来显示消息框)，然后清空两个文本框，使TextBox1具有焦点，如果输入了三次都错误，则显示消息框"对不起，你已经试过三次了。"并退出程序（退出程序用 Application.Exit()方法）。
