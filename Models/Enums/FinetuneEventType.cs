using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FinetuneEventType>))]
public sealed record FinetuneEventType : OpenStringEnum<FinetuneEventType>
{
    private FinetuneEventType(string value) : base(value)
    {
    }

    public static readonly FinetuneEventType JobPending = new("job_pending");

    public static readonly FinetuneEventType JobStart = new("job_start");

    public static readonly FinetuneEventType JobStopped = new("job_stopped");

    public static readonly FinetuneEventType ModelDownloading = new("model_downloading");

    public static readonly FinetuneEventType ModelDownloadComplete = new("model_download_complete");

    public static readonly FinetuneEventType TrainingDataDownloading = new("training_data_downloading");

    public static readonly FinetuneEventType TrainingDataDownloadComplete = new("training_data_download_complete");

    public static readonly FinetuneEventType ValidationDataDownloading = new("validation_data_downloading");

    public static readonly FinetuneEventType ValidationDataDownloadComplete = new("validation_data_download_complete");

    public static readonly FinetuneEventType WandbInit = new("wandb_init");

    public static readonly FinetuneEventType TrainingStart = new("training_start");

    public static readonly FinetuneEventType CheckpointSave = new("checkpoint_save");

    public static readonly FinetuneEventType BillingLimit = new("billing_limit");

    public static readonly FinetuneEventType EpochComplete = new("epoch_complete");

    public static readonly FinetuneEventType TrainingComplete = new("training_complete");

    public static readonly FinetuneEventType ModelCompressing = new("model_compressing");

    public static readonly FinetuneEventType ModelCompressionComplete = new("model_compression_complete");

    public static readonly FinetuneEventType ModelUploading = new("model_uploading");

    public static readonly FinetuneEventType ModelUploadComplete = new("model_upload_complete");

    public static readonly FinetuneEventType JobComplete = new("job_complete");

    public static readonly FinetuneEventType JobError = new("job_error");

    public static readonly FinetuneEventType CancelRequested = new("cancel_requested");

    public static readonly FinetuneEventType JobRestarted = new("job_restarted");

    public static readonly FinetuneEventType Refund = new("refund");

    public static readonly FinetuneEventType Warning = new("warning");

    public static readonly FinetuneEventType EarlyStopped = new("early_stopped");

    public static readonly FinetuneEventType TokenizedDatasetUploadComplete = new("tokenized_dataset_upload_complete");

    public TResult Match<TResult>(Func<TResult> onJobPending,
        Func<TResult> onJobStart,
        Func<TResult> onJobStopped,
        Func<TResult> onModelDownloading,
        Func<TResult> onModelDownloadComplete,
        Func<TResult> onTrainingDataDownloading,
        Func<TResult> onTrainingDataDownloadComplete,
        Func<TResult> onValidationDataDownloading,
        Func<TResult> onValidationDataDownloadComplete,
        Func<TResult> onWandbInit,
        Func<TResult> onTrainingStart,
        Func<TResult> onCheckpointSave,
        Func<TResult> onBillingLimit,
        Func<TResult> onEpochComplete,
        Func<TResult> onTrainingComplete,
        Func<TResult> onModelCompressing,
        Func<TResult> onModelCompressionComplete,
        Func<TResult> onModelUploading,
        Func<TResult> onModelUploadComplete,
        Func<TResult> onJobComplete,
        Func<TResult> onJobError,
        Func<TResult> onCancelRequested,
        Func<TResult> onJobRestarted,
        Func<TResult> onRefund,
        Func<TResult> onWarning,
        Func<TResult> onEarlyStopped,
        Func<TResult> onTokenizedDatasetUploadComplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == JobPending => onJobPending(),
            _ when this == JobStart => onJobStart(),
            _ when this == JobStopped => onJobStopped(),
            _ when this == ModelDownloading => onModelDownloading(),
            _ when this == ModelDownloadComplete => onModelDownloadComplete(),
            _ when this == TrainingDataDownloading => onTrainingDataDownloading(),
            _ when this == TrainingDataDownloadComplete => onTrainingDataDownloadComplete(),
            _ when this == ValidationDataDownloading => onValidationDataDownloading(),
            _ when this == ValidationDataDownloadComplete => onValidationDataDownloadComplete(),
            _ when this == WandbInit => onWandbInit(),
            _ when this == TrainingStart => onTrainingStart(),
            _ when this == CheckpointSave => onCheckpointSave(),
            _ when this == BillingLimit => onBillingLimit(),
            _ when this == EpochComplete => onEpochComplete(),
            _ when this == TrainingComplete => onTrainingComplete(),
            _ when this == ModelCompressing => onModelCompressing(),
            _ when this == ModelCompressionComplete => onModelCompressionComplete(),
            _ when this == ModelUploading => onModelUploading(),
            _ when this == ModelUploadComplete => onModelUploadComplete(),
            _ when this == JobComplete => onJobComplete(),
            _ when this == JobError => onJobError(),
            _ when this == CancelRequested => onCancelRequested(),
            _ when this == JobRestarted => onJobRestarted(),
            _ when this == Refund => onRefund(),
            _ when this == Warning => onWarning(),
            _ when this == EarlyStopped => onEarlyStopped(),
            _ when this == TokenizedDatasetUploadComplete => onTokenizedDatasetUploadComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onJobPending,
        Action onJobStart,
        Action onJobStopped,
        Action onModelDownloading,
        Action onModelDownloadComplete,
        Action onTrainingDataDownloading,
        Action onTrainingDataDownloadComplete,
        Action onValidationDataDownloading,
        Action onValidationDataDownloadComplete,
        Action onWandbInit,
        Action onTrainingStart,
        Action onCheckpointSave,
        Action onBillingLimit,
        Action onEpochComplete,
        Action onTrainingComplete,
        Action onModelCompressing,
        Action onModelCompressionComplete,
        Action onModelUploading,
        Action onModelUploadComplete,
        Action onJobComplete,
        Action onJobError,
        Action onCancelRequested,
        Action onJobRestarted,
        Action onRefund,
        Action onWarning,
        Action onEarlyStopped,
        Action onTokenizedDatasetUploadComplete,
        Action<string> otherwise)
    {
        if (this == JobPending) onJobPending();
        else if (this == JobStart) onJobStart();
        else if (this == JobStopped) onJobStopped();
        else if (this == ModelDownloading) onModelDownloading();
        else if (this == ModelDownloadComplete) onModelDownloadComplete();
        else if (this == TrainingDataDownloading) onTrainingDataDownloading();
        else if (this == TrainingDataDownloadComplete) onTrainingDataDownloadComplete();
        else if (this == ValidationDataDownloading) onValidationDataDownloading();
        else if (this == ValidationDataDownloadComplete) onValidationDataDownloadComplete();
        else if (this == WandbInit) onWandbInit();
        else if (this == TrainingStart) onTrainingStart();
        else if (this == CheckpointSave) onCheckpointSave();
        else if (this == BillingLimit) onBillingLimit();
        else if (this == EpochComplete) onEpochComplete();
        else if (this == TrainingComplete) onTrainingComplete();
        else if (this == ModelCompressing) onModelCompressing();
        else if (this == ModelCompressionComplete) onModelCompressionComplete();
        else if (this == ModelUploading) onModelUploading();
        else if (this == ModelUploadComplete) onModelUploadComplete();
        else if (this == JobComplete) onJobComplete();
        else if (this == JobError) onJobError();
        else if (this == CancelRequested) onCancelRequested();
        else if (this == JobRestarted) onJobRestarted();
        else if (this == Refund) onRefund();
        else if (this == Warning) onWarning();
        else if (this == EarlyStopped) onEarlyStopped();
        else if (this == TokenizedDatasetUploadComplete) onTokenizedDatasetUploadComplete();
        else otherwise(Value);
    }
}
