Up and Running
===============

1.Install .Net engine version manager
————————————————————————————————————-
curl -sSL https://dist.asp.net/dnvm/dnvminstall.sh | sh && source ~/.dnx/dnvm/dnvm.sh

2.Install latest .Net engine
————————————————————————————
dnvm install latest

3.Verify
————————
dnu --version


Discover the skeleton
=====================

#start with a new empty folder
mkdir skeleton
cd skeleton

-- try dnx...fail
dnx 

-- add empty project file
touch project.json
dnx run

-- better file
echo {} > project.json
dnx run

-- add framework section
"frameworks": {
    "dnx451": {}
  }
dnx run

-- now start coding!
public class Program
{
    public void Main(params string[] args)
    {
        System.Console.WriteLine("hello Mix-IT");
    }
}

dnx run




