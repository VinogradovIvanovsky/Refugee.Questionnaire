﻿namespace RQ.DTO;

public class RefRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public long UserId { get; set; }

    public DateTime TimeStamp { get; set; } = DateTime.Now;

    public RefRequestEntry[] Answers { get; set; } = Array.Empty<RefRequestEntry>();
    public bool IsCompleted { get; set; } = false;

    public override string ToString() =>
        $"{TimeStamp}: {(IsCompleted ? "заполнен" : "в процессе")} {Answers.FirstOrDefault()?.Answer} ";
}