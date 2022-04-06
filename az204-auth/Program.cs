using System.Threading.Tasks;

static async void runApp()
{
    await Auth.taskAuth();
}

runApp();