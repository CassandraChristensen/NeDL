export class LikeComponent {
    likesCount: number;
    isSelected: boolean;

    constructor(likesCount: number, isSelected: boolean) {
        this.likesCount = likesCount;
        this.isSelected = isSelected;
    }

    onClick() {
        if (this.isSelected) {
            this.likesCount--;
            this.isSelected = false;
        } 
        else 
        {
            this.likesCount++;
            this.isSelected = true;
        }
    }
}