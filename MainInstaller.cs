using ComputerInterface.Interfaces;
using SophisticatedCube.ComputerInterface;
using Zenject;

namespace SophisticatedCube
{
    public class MainInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<IComputerModEntry>().To<Cubicle>().AsSingle();
        }
    }
}
