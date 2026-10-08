using System.Net.Http;
using TogetherApIs.Api;
using TogetherApIs.Core;
using TogetherApIs.Core.Logging;
using TogetherApIs.Core.Models;

namespace TogetherApIs;

/// <summary>
/// The Together REST API. See https://docs.together.ai for more details.
/// </summary>
public sealed class TogetherApIsClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public TogetherApIsClient(HttpClient httpClient, TogetherApIsClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "TogetherApIsClient/2.0.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "2.0.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "TogetherApIsClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public AbExperimentService AbExperimentService => field ??= new AbExperimentService(_rawClient, _server, _auth);

    public Account Account => field ??= new Account(_rawClient, _server, _auth);

    public AudioApi AudioApi => field ??= new AudioApi(_rawClient, _server, _auth);

    public Batches Batches => field ??= new Batches(_rawClient, _server, _auth);

    public Billing Billing => field ??= new Billing(_rawClient, _server, _auth);

    public Chat Chat => field ??= new Chat(_rawClient, _server, _auth);

    public CodeInterpreter CodeInterpreter => field ??= new CodeInterpreter(_rawClient, _server, _auth);

    public Completion Completion => field ??= new Completion(_rawClient, _server, _auth);

    public ConfigService ConfigService => field ??= new ConfigService(_rawClient, _server, _auth);

    public DeploymentService DeploymentService => field ??= new DeploymentService(_rawClient, _server, _auth);

    public Deployments Deployments => field ??= new Deployments(_rawClient, _server, _auth);

    public DeploymentsStorage DeploymentsStorage => field ??= new DeploymentsStorage(_rawClient, _server, _auth);

    public DeploymentsVolumes DeploymentsVolumes => field ??= new DeploymentsVolumes(_rawClient, _server, _auth);

    public Embeddings Embeddings => field ??= new Embeddings(_rawClient, _server, _auth);

    public EndpointService EndpointService => field ??= new EndpointService(_rawClient, _server, _auth);

    public Endpoints Endpoints => field ??= new Endpoints(_rawClient, _server, _auth);

    public Files Files => field ??= new Files(_rawClient, _server, _auth);

    public FineTuning FineTuning => field ??= new FineTuning(_rawClient, _server, _auth);

    public GpuClusterService GpuClusterService => field ??= new GpuClusterService(_rawClient, _server, _auth);

    public Hardware Hardware => field ??= new Hardware(_rawClient, _server, _auth);

    public HealthCheckService HealthCheckService => field ??= new HealthCheckService(_rawClient, _server, _auth);

    public Images Images => field ??= new Images(_rawClient, _server, _auth);

    public InstanceClusterAddOnService InstanceClusterAddOnService =>
        field ??= new InstanceClusterAddOnService(_rawClient, _server, _auth);

    public InstanceTypeService InstanceTypeService => field ??= new InstanceTypeService(_rawClient, _server, _auth);

    public Jobs Jobs => field ??= new Jobs(_rawClient, _server, _auth);

    public ModelsApi ModelsApi => field ??= new ModelsApi(_rawClient, _server, _auth);

    public PlacementProfileService PlacementProfileService =>
        field ??= new PlacementProfileService(_rawClient, _server, _auth);

    public QueueApi QueueApi => field ??= new QueueApi(_rawClient, _server, _auth);

    public Rl Rl => field ??= new Rl(_rawClient, _server, _auth);

    public RegionService RegionService => field ??= new RegionService(_rawClient, _server, _auth);

    public RemediationService RemediationService => field ??= new RemediationService(_rawClient, _server, _auth);

    public Rerank Rerank => field ??= new Rerank(_rawClient, _server, _auth);

    public RolloutService RolloutService => field ??= new RolloutService(_rawClient, _server, _auth);

    public Secrets Secrets => field ??= new Secrets(_rawClient, _server, _auth);

    public ShadowExperimentService ShadowExperimentService =>
        field ??= new ShadowExperimentService(_rawClient, _server, _auth);

    public SharedVolumeService SharedVolumeService => field ??= new SharedVolumeService(_rawClient, _server, _auth);

    public SupportedModelsService SupportedModelsService =>
        field ??= new SupportedModelsService(_rawClient, _server, _auth);

    public VideoApi VideoApi => field ??= new VideoApi(_rawClient, _server, _auth);

    public Voices Voices => field ??= new Voices(_rawClient, _server, _auth);

    public VolumeService VolumeService => field ??= new VolumeService(_rawClient, _server, _auth);

    public Volumes Volumes => field ??= new Volumes(_rawClient, _server, _auth);

    public Evaluation Evaluation => field ??= new Evaluation(_rawClient, _server, _auth);
}
