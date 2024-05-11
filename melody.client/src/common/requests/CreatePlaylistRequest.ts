export type CreatePlaylistRequest = {
    title: string;
    coversheet?: File | null;
    description: string;
    isPublic: boolean;
    tagIds?: string[];
    creatorId: string;
}