interface ApiConfig {
    host: string;
    port: number;
    baseUrl: string;
}

const api: ApiConfig = {
    host: 'localhost',
    port: 7050,
    get baseUrl(): string {
        return `https://${this.host}:${this.port}/api`;
    }
};

export default api;
