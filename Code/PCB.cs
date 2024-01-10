using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processManage
{
    class PCB //进程控制块
    {
        public int processID; //进程编号(0-9)，标识信息
        public int DR; //定义进程中的变量x，数据缓冲寄存器
        public String processName; //使用该进程块的进程名
        public int priority; //该进程的等级
        public int memory_use; //占用的内存
        public int index; //记录当前使用的内存块的索引
        public string txtcmd; //从文件中获得的命令字符串
        public string[] IR; //命令解析后放在数组中 模拟指令寄存器
        public int blocking_time; //阻塞时间
        public string blocking_reason; //阻塞原因
        public int PSW; //当前进程的程序状态字  1：时钟中断 2：输入输出中断  4：软中断  
        public int PC = 0; //记录此时运行到哪个指令   模拟程序计数器
        public int timeslice = 5; //进程时间片

        public PCB() //对占用内存和阻塞时间进行初始化
        {
            memory_use = 1;
            blocking_time = 0;
            index = -1;
        }

        public void gettxt(string cmd) //根据;来解析命令
        {
            txtcmd = cmd; //将获得的字符串赋值给PCB的cmd
            char[] sp = { ';' };
            IR = cmd.Split(sp, StringSplitOptions.RemoveEmptyEntries); //将按照;解析出来的命令放在数组中
        }
    }
}