export class Identity {
    uid: string = '';
    displayName: string = '';
    email: string = '';
    
    get isAnonymous() {
        return !(this.uid && this.email);
    }
}