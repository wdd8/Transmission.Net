using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Transmission.Net.Api;

/// <summary>
/// Compatibility with Transmission before 4.1.0 (rpc_version_semver 6.0.0).
/// </summary>
internal static class LegacyRpc
{
    private static readonly Dictionary<string, string> ToLegacy = new()
    {
        // Methods
        { "blocklist_update", "blocklist-update" },
        { "free_space", "free-space" },
        { "port_test", "port-test" },
        { "queue_move_bottom", "queue-move-bottom" },
        { "queue_move_down", "queue-move-down" },
        { "queue_move_top", "queue-move-top" },
        { "queue_move_up", "queue-move-up" },
        { "session_close", "session-close" },
        { "session_get", "session-get" },
        { "session_set", "session-set" },
        { "session_stats", "session-stats" },
        { "torrent_add", "torrent-add" },
        { "torrent_get", "torrent-get" },
        { "torrent_reannounce", "torrent-reannounce" },
        { "torrent_remove", "torrent-remove" },
        { "torrent_rename_path", "torrent-rename-path" },
        { "torrent_set", "torrent-set" },
        { "torrent_set_location", "torrent-set-location" },
        { "torrent_start", "torrent-start" },
        { "torrent_start_now", "torrent-start-now" },
        { "torrent_stop", "torrent-stop" },
        { "torrent_verify", "torrent-verify" },

        // Method arguments and results
        { "delete_local_data", "delete-local-data" },
        { "files_unwanted", "files-unwanted" },
        { "files_wanted", "files-wanted" },
        { "port_is_open", "port-is-open" },
        { "priority_high", "priority-high" },
        { "priority_low", "priority-low" },
        { "priority_normal", "priority-normal" },
        { "recently_active", "recently-active" },
        { "torrent_added", "torrent-added" },
        { "torrent_duplicate", "torrent-duplicate" },
        { "tracker_add", "trackerAdd" },
        { "tracker_remove", "trackerRemove" },

        // Torrent fields
        { "activity_date", "activityDate" },
        { "added_date", "addedDate" },
        { "bandwidth_priority", "bandwidthPriority" },
        { "corrupt_ever", "corruptEver" },
        { "date_created", "dateCreated" },
        { "desired_available", "desiredAvailable" },
        { "done_date", "doneDate" },
        { "downloaded_ever", "downloadedEver" },
        { "download_limit", "downloadLimit" },
        { "download_limited", "downloadLimited" },
        { "edit_date", "editDate" },
        { "error_string", "errorString" },
        { "eta_idle", "etaIdle" },
        { "file_count", "file-count" },
        { "file_stats", "fileStats" },
        { "hash_string", "hashString" },
        { "have_unchecked", "haveUnchecked" },
        { "have_valid", "haveValid" },
        { "honors_session_limits", "honorsSessionLimits" },
        { "is_finished", "isFinished" },
        { "is_private", "isPrivate" },
        { "is_stalled", "isStalled" },
        { "left_until_done", "leftUntilDone" },
        { "magnet_link", "magnetLink" },
        { "manual_announce_time", "manualAnnounceTime" },
        { "max_connected_peers", "maxConnectedPeers" },
        { "metadata_percent_complete", "metadataPercentComplete" },
        { "peer_limit", "peer-limit" },
        { "peers_connected", "peersConnected" },
        { "peers_from", "peersFrom" },
        { "peers_getting_from_us", "peersGettingFromUs" },
        { "peers_sending_to_us", "peersSendingToUs" },
        { "percent_complete", "percentComplete" },
        { "percent_done", "percentDone" },
        { "piece_count", "pieceCount" },
        { "piece_size", "pieceSize" },
        { "primary_mime_type", "primary-mime-type" },
        { "queue_position", "queuePosition" },
        { "rate_download", "rateDownload" },
        { "rate_upload", "rateUpload" },
        { "recheck_progress", "recheckProgress" },
        { "seconds_downloading", "secondsDownloading" },
        { "seconds_seeding", "secondsSeeding" },
        { "seed_idle_limit", "seedIdleLimit" },
        { "seed_idle_mode", "seedIdleMode" },
        { "seed_ratio_limit", "seedRatioLimit" },
        { "seed_ratio_mode", "seedRatioMode" },
        { "size_when_done", "sizeWhenDone" },
        { "start_date", "startDate" },
        { "torrent_file", "torrentFile" },
        { "total_size", "totalSize" },
        { "tracker_list", "trackerList" },
        { "tracker_stats", "trackerStats" },
        { "uploaded_ever", "uploadedEver" },
        { "upload_limit", "uploadLimit" },
        { "upload_limited", "uploadLimited" },
        { "upload_ratio", "uploadRatio" },
        { "webseeds_sending_to_us", "webseedsSendingToUs" },

        // Torrent files
        { "bytes_completed", "bytesCompleted" },

        // Torrent peers
        { "client_is_choked", "clientIsChoked" },
        { "client_is_interested", "clientIsInterested" },
        { "client_name", "clientName" },
        { "flag_str", "flagStr" },
        { "is_downloading_from", "isDownloadingFrom" },
        { "is_encrypted", "isEncrypted" },
        { "is_uploading_to", "isUploadingTo" },
        { "is_utp", "isUTP" },
        { "peer_is_choked", "peerIsChoked" },
        { "peer_is_interested", "peerIsInterested" },
        { "rate_to_client", "rateToClient" },
        { "rate_to_peer", "rateToPeer" },

        // Torrent peers from
        { "from_dht", "fromDht" },
        { "from_incoming", "fromIncoming" },
        { "from_lpd", "fromLpd" },
        { "from_ltep", "fromLtep" },
        { "from_pex", "fromPex" },
        { "from_tracker", "fromTracker" },

        // Torrent tracker stats
        { "announce_state", "announceState" },
        { "download_count", "downloadCount" },
        { "has_announced", "hasAnnounced" },
        { "has_scraped", "hasScraped" },
        { "is_backup", "isBackup" },
        { "last_announce_peer_count", "lastAnnouncePeerCount" },
        { "last_announce_result", "lastAnnounceResult" },
        { "last_announce_start_time", "lastAnnounceStartTime" },
        { "last_announce_succeeded", "lastAnnounceSucceeded" },
        { "last_announce_time", "lastAnnounceTime" },
        { "last_announce_timed_out", "lastAnnounceTimedOut" },
        { "last_scrape_result", "lastScrapeResult" },
        { "last_scrape_start_time", "lastScrapeStartTime" },
        { "last_scrape_succeeded", "lastScrapeSucceeded" },
        { "last_scrape_time", "lastScrapeTime" },
        { "last_scrape_timed_out", "lastScrapeTimedOut" },
        { "leecher_count", "leecherCount" },
        { "next_announce_time", "nextAnnounceTime" },
        { "next_scrape_time", "nextScrapeTime" },
        { "scrape_state", "scrapeState" },
        { "seeder_count", "seederCount" },

        // Session
        { "alt_speed_down", "alt-speed-down" },
        { "alt_speed_enabled", "alt-speed-enabled" },
        { "alt_speed_time_begin", "alt-speed-time-begin" },
        { "alt_speed_time_day", "alt-speed-time-day" },
        { "alt_speed_time_enabled", "alt-speed-time-enabled" },
        { "alt_speed_time_end", "alt-speed-time-end" },
        { "alt_speed_up", "alt-speed-up" },
        { "blocklist_enabled", "blocklist-enabled" },
        { "blocklist_size", "blocklist-size" },
        { "blocklist_url", "blocklist-url" },
        { "cache_size_mib", "cache-size-mb" },
        { "config_dir", "config-dir" },
        { "dht_enabled", "dht-enabled" },
        { "download_dir", "download-dir" },
        { "download_dir_free_space", "download-dir-free-space" },
        { "download_queue_enabled", "download-queue-enabled" },
        { "download_queue_size", "download-queue-size" },
        { "idle_seeding_limit", "idle-seeding-limit" },
        { "idle_seeding_limit_enabled", "idle-seeding-limit-enabled" },
        { "incomplete_dir", "incomplete-dir" },
        { "incomplete_dir_enabled", "incomplete-dir-enabled" },
        { "lpd_enabled", "lpd-enabled" },
        { "peer_limit_global", "peer-limit-global" },
        { "peer_limit_per_torrent", "peer-limit-per-torrent" },
        { "peer_port", "peer-port" },
        { "peer_port_random_on_start", "peer-port-random-on-start" },
        { "pex_enabled", "pex-enabled" },
        { "port_forwarding_enabled", "port-forwarding-enabled" },
        { "queue_stalled_enabled", "queue-stalled-enabled" },
        { "queue_stalled_minutes", "queue-stalled-minutes" },
        { "rename_partial_files", "rename-partial-files" },
        { "rpc_version", "rpc-version" },
        { "rpc_version_minimum", "rpc-version-minimum" },
        { "script_torrent_done_enabled", "script-torrent-done-enabled" },
        { "script_torrent_done_filename", "script-torrent-done-filename" },
        { "seed_queue_enabled", "seed-queue-enabled" },
        { "seed_queue_size", "seed-queue-size" },
        { "seed_ratio_limited", "seedRatioLimited" },
        { "session_id", "session-id" },
        { "speed_limit_down", "speed-limit-down" },
        { "speed_limit_down_enabled", "speed-limit-down-enabled" },
        { "speed_limit_up", "speed-limit-up" },
        { "speed_limit_up_enabled", "speed-limit-up-enabled" },
        { "start_added_torrents", "start-added-torrents" },
        { "trash_original_torrent_files", "trash-original-torrent-files" },
        { "utp_enabled", "utp-enabled" },

        // Session units
        { "memory_bytes", "memory-bytes" },
        { "memory_units", "memory-units" },
        { "size_bytes", "size-bytes" },
        { "size_units", "size-units" },
        { "speed_bytes", "speed-bytes" },
        { "speed_units", "speed-units" },

        // Session stats
        { "active_torrent_count", "activeTorrentCount" },
        { "cumulative_stats", "cumulative-stats" },
        { "current_stats", "current-stats" },
        { "downloaded_bytes", "downloadedBytes" },
        { "download_speed", "downloadSpeed" },
        { "files_added", "filesAdded" },
        { "paused_torrent_count", "pausedTorrentCount" },
        { "seconds_active", "secondsActive" },
        { "session_count", "sessionCount" },
        { "torrent_count", "torrentCount" },
        { "uploaded_bytes", "uploadedBytes" },
        { "upload_speed", "uploadSpeed" },
    };

    private static readonly Dictionary<string, string> FromLegacy = new(ToLegacy
        .Select(x => KeyValuePair.Create(x.Value, x.Key))
        .Append(KeyValuePair.Create("downloadDir", "download_dir")));

    public static string ToJson(TransmissionRequest request)
    {
        // download_dir is downloadDir in torrent-get and torrent-set, and download-dir everywhere else.
        var arguments = request.Parameters == null ? null : (JObject)Rename(JObject.FromObject(request.Parameters),
            x => x == "download_dir" ? ["download-dir", "downloadDir"] : [ToLegacy.GetValueOrDefault(x, x)]);

        if ((string?)arguments?["encryption"] == "allowed")
        {
            arguments!["encryption"] = "tolerated";
        }

        return new JObject
        {
            { "method", ToLegacy.GetValueOrDefault(request.Method, request.Method) },
            { "arguments", arguments },
            { "tag", request.Id }
        }.ToString(Formatting.None);
    }

    public static TransmissionResponse FromJson(string json)
    {
        var response = JObject.Parse(json);
        var result = (string?)response["result"];
        var arguments = response["arguments"] is JObject args ? (JObject)Rename(args, x => [FromLegacy.GetValueOrDefault(x, x)]) : null;

        if ((string?)arguments?["encryption"] == "tolerated")
        {
            arguments!["encryption"] = "allowed";
        }

        return new TransmissionResponse
        {
            Id = (int?)response["tag"],
            Result = arguments,
            Error = result == "success" ? null : new TransmissionError { Message = result ?? "Invalid response" }
        };
    }

    private static JToken Rename(JToken token, Func<string, string[]> names, bool values = false)
    {
        switch (token)
        {
            case JObject obj:
                var renamed = new JObject();

                foreach (var property in obj.Properties())
                {
                    foreach (var name in names(property.Name))
                    {
                        // Both legacy names of download_dir may be present, keep the first
                        renamed[name] ??= Rename(property.Value, names, property.Name is "fields" or "ids");
                    }
                }

                return renamed;
            case JArray array:
                return new JArray(array.SelectMany(x => values && x.Type == JTokenType.String ?
                    names((string)x!).Select(name => (JToken)new JValue(name)) :
                    Rename(x, names, values)]));
            case JValue { Type: JTokenType.String } value when values:
                return new JValue(names((string)value!)[0]);
            default:
                return token;
        }
    }
}
