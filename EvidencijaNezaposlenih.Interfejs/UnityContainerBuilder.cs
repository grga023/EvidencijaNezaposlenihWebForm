using EvidencijaNezaposlenih.Repozitorijum.Domeni.Context;
using EvidencijaNezaposlenih.Repozitorijum.Interface;
using EvidencijaNezaposlenih.Repozitorijum.Repozitorijumi;
using EvidencijaNezaposlenih.Servisi.Interfejsi;
using EvidencijaNezaposlenih.Servisi.Servisi;
using Unity;
using Unity.Injection;

public class UnityContainerBuilders
{
    private readonly IUnityContainer container;

    public UnityContainerBuilders()
    {
        container = new UnityContainer();
        container.AddExtension(new Diagnostic());

    }

    public UnityContainerBuilders RegisterDependencies()
    {


        // Register dependencies here
        container.RegisterType<NezaposleniDbContext>(new InjectionConstructor(new DbContextOptionsBuilder<NezaposleniDbContext>().UseSqlServer(connectionString).Options));

        container.RegisterType<INezaposleniServis, NezaposleniServis>();
        container.RegisterType<INezaposleniRepozitorijum, NezaposleniRepozitorijum>();
        container.RegisterType<IFirmaRepozitorijum, FirmaRepozitorijum>();

        return this;
    }

    public IUnityContainer Build()
    {
        return container;
    }
}
