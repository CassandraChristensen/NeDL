import { Pipe, PipeTransform } from "@angular/core";


@Pipe({
    name: 'summary'
})
export class SummaryPipe implements PipeTransform {
    //Search on angular.io (pipetransform and it'll tell you how it works. )

    transform(value: string, limit?: number) {

        if (!value)
            return null;

        let actualLimit = (limit) ? limit : 50;
        return value.substring(0, actualLimit) + '...';
    }
}