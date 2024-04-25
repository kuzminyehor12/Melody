import { SearchType } from "../enums/SearchType";

export class FilterOptions {
    type: SearchType = SearchType.Track;
    tagIds: string[] = []; // tracks and playlists
    genreIds: string[] = []; // tracks
}