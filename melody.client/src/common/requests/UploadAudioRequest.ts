import { AudioType } from "../enums/AudioType";

export type UploadAudioRequest = {
    title: string;
    author: string;
    file: File | null;
    type: AudioType;
    description: string | undefined | null;
    genreIds: string[];
    collectionId: string | undefined | null;
    creatorId: string;
}