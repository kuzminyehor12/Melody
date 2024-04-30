export type CreatePlaylistRequest = {
    author: string;
    title: string;
    coversheet?: File | null;
    description: string;
    isPublic: boolean;
    tagIds?: string[];
}